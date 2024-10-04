using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class RequestRepository : IRequestRepository
    {
        private readonly WorkDbContext context;

        public RequestRepository(WorkDbContext context)
        {
            this.context = context;
        }

        public Request Create(Request request)
        {
            context.Requests.Add(request);
            context.SaveChanges();
            return request; 
        }

        public List<Request> GetAll()
        {
            return context.Requests.ToList();
        }

        public Request GetByDepartment()
        {
            throw new NotImplementedException();
        }

        public Request UpdateConfirm(int id, Request request)
        {
            var existRequest = context.Requests.FirstOrDefault(x => x.Id == id);
            if (existRequest == null) return null;
            existRequest.Status = request.Status;
            existRequest.AssignedTo = request.AssignedTo;
            context.SaveChanges();
            return existRequest;
        }

        public Request UpdateSuccess(int id, Request request)
        {
            var existRequest = context.Requests.FirstOrDefault(x => x.Id == id);
            if (existRequest == null) return null;
            existRequest.Status = request.Status;
            context.SaveChanges();
            return existRequest;
        }
    }
}
