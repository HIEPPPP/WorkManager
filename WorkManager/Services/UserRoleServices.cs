using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class UserRoleServices
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleServices(IUserRoleRepository userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }

        public List<UserRole> GetUserRoleByUserCode(string userCode)
        {
            return userRoleRepository.GetUserRoleByUserCode(userCode);  
        }
    }
}
