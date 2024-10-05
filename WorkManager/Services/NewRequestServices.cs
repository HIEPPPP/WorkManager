using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class NewRequestServices
    {
        private readonly INewRequestRepository newRequestRepository;

        public NewRequestServices(INewRequestRepository newRequestRepository)
        {
            this.newRequestRepository = newRequestRepository;
        }

        public NewRequest GetNewRequest()
        {
            return newRequestRepository.Get();
        }

        public NewRequest CreateNewRequest(NewRequest newRequest)
        {
            return newRequestRepository.Create(newRequest);
        }

        public NewRequest UpdateIsHandle(int id, NewRequest newRequest)
        {
            var existNewRequest = newRequestRepository.Update(id, newRequest);
            if (existNewRequest == null) return null;
            return existNewRequest;
        }
    }
}
