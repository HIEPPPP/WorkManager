using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unity;
using WorkManager.GUI;

namespace WorkManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IUnityContainer container;

        public frmMain(IUnityContainer container)
        {
            InitializeComponent();
            this.container = container;            
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