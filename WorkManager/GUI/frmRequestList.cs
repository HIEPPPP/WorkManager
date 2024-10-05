using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using WorkManager.Contranst;
using WorkManager.Models.Model;
using WorkManager.Services;

namespace WorkManager.GUI
{
    public partial class frmRequestList : DevExpress.XtraEditors.XtraForm
    {
        private readonly RequestServices requestServices;
        private readonly IUnityContainer container;

        public int Id { get; set; }

        public frmRequestList(RequestServices requestServices, IUnityContainer container)
        {
            InitializeComponent();
            this.requestServices = requestServices;
            this.container = container;            
        }

        void LoadData()
        {
            gcRequest.DataSource = requestServices.GetListRequest();
        }

        private void gcRequest_Load(object sender, EventArgs e)
        {
           LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmRequestAdd = container.Resolve<frmRequestAdd>();
            frmRequestAdd.FormClosed += new FormClosedEventHandler(gcRequest_Load);
            frmRequestAdd.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Request
                {
                    AssignedTo = Work_Constants.username,
                    Status = "Đang thực hiện"
                };
                requestServices.UpdateConfirmRequest(Id, request);
                LoadData();
                MessageBox.Show("Đã xác nhận");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Lỗi " +  ex.Message);
            }            
        }

        private void gvRequest_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {           
            var idSelected = gvRequest.GetFocusedRowCellValue("Id");
            var displayName = gvRequest.GetFocusedRowCellValue("AssignedTo");
            if (idSelected == null) idSelected = 0;                       
            Id = Convert.ToInt32(idSelected);
            
            if (displayName == null)
            {
                btnSuccess.Visible = false;
                displayName = string.Empty; 
            }
            if (Work_Constants.username == displayName.ToString())
            {
                btnSuccess.Visible = true;
            }
            else
            {
                btnSuccess.Visible = false;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            var request = new Request
            {
                Status = "Hoàn thành"
            };
            requestServices.UpdateSuccessRequest(Id, request);
            LoadData(); 
            MessageBox.Show("Đã hoàn thành");
        }

        private void gvRequest_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0 && e.Column.FieldName == "Status") // Kiểm tra dòng dữ liệu và đúng cột "Amount"
            {
                string status = Convert.ToString(view.GetRowCellValue(e.RowHandle, view.Columns["Status"]));

                // Nếu số lượng nhỏ hơn hoặc bằng 10, tô màu ô thành màu đỏ
                if (status == "Chưa hỗ trợ")
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.ForeColor = Color.White;
                }
                else if (status == "Đang thực hiện")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    // Đặt màu mặc định nếu không thỏa điều kiện
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }
    }
}