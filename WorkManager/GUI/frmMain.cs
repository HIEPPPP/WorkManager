using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unity;
using WorkManager.GUI;
using WorkManager.Models.Model;
using WorkManager.Services;

namespace WorkManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IUnityContainer container;
        private readonly NewRequestServices newRequestServices;
        private Timer checkNewRequestTimer;

        public frmMain(IUnityContainer container, NewRequestServices newRequestServices)
        {
            InitializeComponent();
            this.container = container;
            this.newRequestServices = newRequestServices;
            checkNewRequestTimer = new Timer();
            checkNewRequestTimer.Interval = 5000; // Kiểm tra mỗi 5 giây
            checkNewRequestTimer.Tick += CheckNewRequestTimer_Tick;
            checkNewRequestTimer.Start();
        }

        private void CheckNewRequestTimer_Tick(object sender, EventArgs e)
        {
            var newRequest = newRequestServices.GetNewRequest();

            if (newRequest != null)
            {
                int id = Convert.ToInt32(newRequest.Id);
                string requestType = newRequest.RequestType.ToString();
                string department = newRequest.Department.ToString();

                if (requestType == "Yêu cầu hỗ trợ")
                {
                    // Hiển thị thông báo nếu có yêu cầu hỗ trợ mới
                    string message = $"Có yêu cầu hỗ trợ mới từ {department}";
                    DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo("Yêu cầu hỗ trợ mới", message);
                    alertControl.Show(this, info);
                }

                MarkRequestAsHandled(id, newRequest);
            }
        }

        private void MarkRequestAsHandled(int requestID, NewRequest newRequest)
        {
            newRequestServices.UpdateIsHandle(requestID, newRequest);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Khi form chính load, hiển thị form frmComponent
            OpenUniqueForm<frmRequestList>();            
        }

        // Hàm kiểm tra và mở form duy nhất
        private void OpenUniqueForm<T>() where T : Form
        {
            // Kiểm tra nếu form đã mở
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    // Nếu form đã mở, kích hoạt form đó
                    form.Activate();
                    return;
                }
            }

            // Nếu form chưa mở, tạo mới và hiển thị
            var frm = container.Resolve<T>();
            frm.MdiParent = this;
            frm.Show();
        }        
        

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmResquestAdd = container.Resolve<frmRequestAdd>();   
            frmResquestAdd.ShowDialog();
        }

        
    }
}