using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Repository.Implementation
{
    public class FactoryRepository : IFactoryRepository
    {
        private readonly WorkDbContext context;

        public FactoryRepository(WorkDbContext context)
        {
            this.context = context;
        }
        public List<Factory> GetAll()
        {
            return context.Factories.ToList();
        }
    }
}
