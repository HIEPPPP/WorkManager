using DevExpress.XtraEditors;
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
using WorkManager.Contranst;
using WorkManager.Models.Model;
using WorkManager.Services;

namespace WorkManager.GUI
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserServices userServices;
        private readonly IUnityContainer container;
        private readonly UserRoleServices userRoleServices;

        public frmLogin(UserServices userServices, IUnityContainer container, UserRoleServices userRoleServices)
        {
            InitializeComponent();
            this.userServices = userServices;
            this.container = container;
            this.userRoleServices = userRoleServices;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userCode = txtUserCode.Text.ToString().Trim();
            var password = txtPassword.Text.ToString().Trim();
            if (string.IsNullOrEmpty(userCode) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = userServices.Login(userCode, password);
            if (result)
            {
                Work_Constants.userCode = userCode;
                Work_Constants.password = password;
                Work_Constants.username = userServices.GetUserLogin(userCode).ToString();
                List<UserRole> roles = userRoleServices.GetUserRoleByUserCode(userCode);
                if (roles.Count > 0)
                {
                    Work_Constants.userRoles = roles;
                }
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frmMain = container.Resolve<frmMain>();
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}