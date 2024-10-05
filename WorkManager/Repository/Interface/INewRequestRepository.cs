using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;

namespace WorkManager.Repository.Interface
{
    public interface INewRequestRepository
    {
        NewRequest Get();
        NewRequest Create(NewRequest newRequest);
        NewRequest Update(int id, NewRequest newRequest);
    }
}
