using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Entity;

namespace Feeder.Model.Service
{
    public class FeederService : IFeederService
    {
        public event Action UpdateFeeders;
        private readonly IRepository<FeederEntity> _repository;
        public FeederService(IRepository<FeederEntity> repository)
        {
            _repository = repository;
        }
        public void AddFeeder(FeederEntity feeder)
        {
            _repository.Add(feeder);
            UpdateFeeders?.Invoke();
        }
    }
}
