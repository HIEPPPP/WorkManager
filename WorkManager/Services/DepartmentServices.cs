using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class DepartmentServices
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentServices(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public List<Department> GetListDepartment() 
        {
            return departmentRepository.GetAll();
        } 
    }
}
