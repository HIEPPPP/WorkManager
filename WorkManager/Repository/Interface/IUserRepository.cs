using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;

namespace WorkManager.Repository.Interface
{
    public interface IUserRepository
    {
        List<User> GetUserByDepartment(string department);

        bool Login(string userCode, string password);

        User GetUserLogin(string userCode);
    }
}
