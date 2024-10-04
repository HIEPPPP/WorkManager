using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;

namespace WorkManager.Repository.Interface
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
    }
}
