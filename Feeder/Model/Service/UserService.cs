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
        /*private readonly IRepository<User> usersRepository;
        public UserService(IRepository<User> repository)
        {
            usersRepository = repository;
        }

        public void RegisterUser(User user)
        {
            usersRepository.Add(user);
        }*/

        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public void RegisterUser(User user)
        {
            _repository.Add(user);
        }
    }
}
 