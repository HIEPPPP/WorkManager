using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly WorkDbContext context;

        public UserRoleRepository(WorkDbContext context)
        {
            this.context = context;
        }
        public List<UserRole> GetUserRoleByUserCode(string userCode)
        {
            var existUserRole = context.UserRoles.Where(x => x.UserCode.Contains(userCode));
            if (existUserRole == null)
            {
                return null;
            }
            return existUserRole.ToList();
        }
    }
}
