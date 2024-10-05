using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class NewRequestRepository : INewRequestRepository
    {
        private readonly WorkDbContext context;

        public NewRequestRepository(WorkDbContext context)
        {
            this.context = context;
        }

        public NewRequest Create(NewRequest newRequest)
        {
            context.NewRequests.Add(newRequest);
            context.SaveChanges();
            return newRequest;
        }

        public NewRequest Get()
        {
            var request = context.NewRequests
              .Where(r => r.IsHandled == false)
              .OrderByDescending(r => r.CreatedDate)
              .FirstOrDefault();
            return request;            
        }

        public NewRequest Update(int id, NewRequest newRequest)
        {
            var existRequest = context.NewRequests.Where(x => x.Id == id).FirstOrDefault();
            if (existRequest == null) return null;
            existRequest.IsHandled = true;
            context.SaveChanges();
            return existRequest;
        }
    }
}
