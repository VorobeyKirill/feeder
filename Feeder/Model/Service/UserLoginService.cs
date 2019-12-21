using Feeder.Model.Repository;
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
        private readonly UserRepository userRepository;
        public UserLoginService(UserRepository repository)
        {
            userRepository = repository;
        }

        public bool CheckForUser(User user)
        {
            return userRepository.CheckForOverlaps(user);
        }
    }
}
