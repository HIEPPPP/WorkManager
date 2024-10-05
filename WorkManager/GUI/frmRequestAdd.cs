using DevExpress.XtraBars.Alerter;
using DevExpress.XtraEditors;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkManager.Models.Model;
using WorkManager.Services;

namespace WorkManager.GUI
{
    public partial class frmRequestAdd : DevExpress.XtraEditors.XtraForm
    {
        private readonly DepartmentServices departmentServices;
        private readonly FactoryServices factoryServices;
        private readonly UserServices userServices;
        private readonly RequestServices requestServices;
        private readonly NewRequestServices newRequestServices;        

        public frmRequestAdd(DepartmentServices departmentServices, FactoryServices factoryServices, UserServices userServices, RequestServices requestServices, NewRequestServices newRequestServices)
        {
            InitializeComponent();
            this.departmentServices = departmentServices;
            this.factoryServices = factoryServices;
            this.userServices = userServices;
            this.requestServices = requestServices;
            this.newRequestServices = newRequestServices;
        }        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new Request
                {
                    Factory = cbFactory.Text.ToString(),
                    Department = cbDepartment.Text.ToString(),
                    RequestType = cbRequestType.Text.ToString(),
                    RequestBy = cbRequestBy.Text.ToString(),
                    Location = txtLocation.Text.ToString(),
                    Description = txtDesc.Text.ToString(),
                    CreateDate = DateTime.Now,
                    Status = "Chưa hỗ trợ",
                };

                var newRequest = new NewRequest
                {
                    RequestType = cbRequestType.Text.ToString(),
                    Department = cbDepartment.Text.ToString(),
                    CreatedDate = DateTime.Now,
                    IsHandled = false,
                };

                requestServices.CreateRequest(request);
                newRequestServices.CreateNewRequest(newRequest);
                MessageBox.Show("Yêu cầu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }

        private void frmRequestAdd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            cbDepartment.Properties.DataSource = departmentServices.GetListDepartment();
            cbDepartment.Properties.DisplayMember = "ShortName";
            cbDepartment.Properties.ValueMember = "Name";

            cbFactory.Properties.DataSource = factoryServices.GetListFactory();
            cbFactory.Properties.DisplayMember = "Name";
            cbFactory.Properties.ValueMember = "Name";
        }

        private void cbDepartment_EditValueChanged(object sender, EventArgs e)
        {
            string department = cbDepartment.Text;
            if (department != null)
            {

                cbRequestBy.ReadOnly = false;
            }

            cbRequestBy.Properties.DataSource = userServices.GetListUserByDepartment(cbDepartment.Text.ToString());
            cbRequestBy.Properties.DisplayMember = "DisplayName";
            cbRequestBy.Properties.ValueMember = "UserCode";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void AlertControl_AlertClick(object sender, DevExpress.XtraBars.Alerter.AlertClickEventArgs e)
        {

        }        
    }
}