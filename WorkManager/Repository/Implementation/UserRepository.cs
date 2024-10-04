using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly WorkDbContext context;

        public UserRepository(WorkDbContext context)
        {
            this.context = context;
        }
        public List<User> GetUserByDepartment(string department)
        {
            return context.Users
                  .Where(x => x.Department == department)
                  .ToList();
        }

        public User GetUserLogin(string userCode)
        {
            var existUser = context.Users.FirstOrDefault(x => x.UserCode == userCode);
            if (existUser == null) return null;
            return existUser;
        }

        public bool Login(string userCode , string password)
        {
            var user = context.Users.Where(x => x.UserCode == userCode && x.Password == password).FirstOrDefault();    
            return user != null;
        }
    }
}
