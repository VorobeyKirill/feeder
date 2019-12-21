using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feeder.Model.Repository;
using Model;
using Model.Entity;
using Model.Service;

namespace Feeder.Model.Service
{
    public class FeederService : IFeederService
    {
        public event Action UpdateFeeders;
        private readonly IRepository<FeederEntity> _feederRepository;
        private readonly IRepository<User> _userRepository;
        private readonly UserRepository _repository;
        public FeederService(IRepository<FeederEntity> feederRepository)
        {
            _feederRepository = feederRepository;
        }
        public void AddFeeder(FeederEntity feeder)
        {
            _feederRepository.Add(feeder);
            
            foreach(var item in _feederRepository.GetAll())
            {
                if(item.UserName == _repository.GetCurrentUser().Name)
                {
                    _repository.AddFeeder(item);
                }
            }
            UpdateFeeders?.Invoke();
        }
    }
}
