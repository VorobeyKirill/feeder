using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IRepository<User> usersRepository;
        public UserLoginService(IRepository<User> repository)
        {
            usersRepository = repository;
        }

        public bool CheckForUser(User user)
        {
            return usersRepository.CheckForOverlaps(user);
        }
    }
}
