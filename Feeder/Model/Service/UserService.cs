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
        private readonly IRepository<User> usersRepository;
        public UserService(IRepository<User> repository)
        {
            usersRepository = repository;
        }

        public void RegisterUser(User user)
        {
            usersRepository.Add(user);
        }
    }
}
