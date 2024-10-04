using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;

namespace WorkManager.Repository.Interface
{
    public interface IRequestRepository
    {
        List<Request> GetAll();
        Request GetByDepartment();

        Request Create(Request request);

        Request UpdateConfirm(int id, Request request);

        Request UpdateSuccess(int id, Request request);
    }
}
