using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly WorkDbContext context;

        public DepartmentRepository(WorkDbContext context)
        {
            this.context = context;
        }
        public List<Department> GetAll()
        {
            return context.Departments.ToList();    
        }
    }
}
