using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class RequestServices
    {
        private readonly IRequestRepository requestRepository;

        public RequestServices(IRequestRepository requestRepository)
        {
            this.requestRepository = requestRepository;
        }

        public List<Request> GetListRequest()
        {
            return requestRepository.GetAll();
        }

        public Request CreateRequest(Request request)
        {
            return requestRepository.Create(request);    
        }

        public Request UpdateConfirmRequest(int id, Request request)
        {
            return requestRepository.UpdateConfirm(id, request);
        }

        public Request UpdateSuccessRequest(int id, Request request)
        {
            return requestRepository.UpdateSuccess(id, request);
        }

    }
}
