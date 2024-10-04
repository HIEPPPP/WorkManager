using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class UserServices
    {
        private readonly IUserRepository userRepository;

        public UserServices(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> GetListUserByDepartment(string department)
        {
            return userRepository.GetUserByDepartment(department);
        }

        public bool Login(string userCode, string password)
        {
            return userRepository.Login(userCode, password);
        }

        public string GetUserLogin(string userCode)
        {
            return userRepository.GetUserLogin(userCode).DisplayName;
        }
    }
}
