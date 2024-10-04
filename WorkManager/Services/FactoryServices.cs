using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManager.Models.Model;
using WorkManager.Repository.Interface;

namespace WorkManager.Services
{
    public class FactoryServices
    {
        private readonly IFactoryRepository factoryRepository;

        public FactoryServices(IFactoryRepository factoryRepository)
        {
            this.factoryRepository = factoryRepository;
        }

        public List<Factory> GetListFactory()
        {
            return factoryRepository.GetAll();
        }
    }
}
