using Feeder.Model.Repository;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class UserService : IUserService
    {
        public User CurrentUser { get; set; }
        public event Action UpdateFeeders;

        /*private readonly IRepository<User> usersRepository;
public UserService(IRepository<User> repository)
{
   usersRepository = repository;
}

public void RegisterUser(User user)
{
   usersRepository.Add(user);
}*/

        private readonly UserRepository _repository;
        public UserService(UserRepository repository)
        {
            _repository = repository;
        }
        public void RegisterUser(User user)
        {
            _repository.Add(user);
            CurrentUser = user;
        }
        public void AddFeeder(FeederEntity feeder, string userName)
        {
            _repository.AddFeeder(feeder, userName);
            UpdateFeeders?.Invoke();
            
        }
        public User Find(string userName)
        {
            return _repository.Find(userName);
        }
        public List<FeederEntity> GetFeeders(string userName)
        {
            return _repository.GetFeeders(userName);
        }
            
    }
}
 