using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using WorkManager.GUI;
using WorkManager.Repository.Implementation;
using WorkManager.Repository.Interface;
using WorkManager.Services;

namespace WorkManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new UnityContainer().AddExtension(new Diagnostic());


            //Đăng ký Repo 
            container.RegisterType<IRequestRepository, RequestRepository>();
            container.RegisterType<IDepartmentRepository, DepartmentRepository>();
            container.RegisterType<IFactoryRepository, FactoryRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IUserRoleRepository, UserRoleRepository>();

            //Đăng ký Service
            container.RegisterType<DepartmentServices>();
            container.RegisterType<FactoryServices>();
            container.RegisterType<RequestServices>();
            container.RegisterType<UserServices>();
            container.RegisterType<UserRoleServices>();

            //Đăng ký Form
            container.RegisterType<frmMain>();
            container.RegisterType<frmRequestAdd>();
            container.RegisterType<frmRequestList>();
            container.RegisterType<frmLogin>();

            var mainForm = container.Resolve<frmLogin>();


            Application.Run(mainForm);
        }
    }
}
