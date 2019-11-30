using model.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Service
{
    public class UserService : IUserLoginService
    {
        public event Action UserUpdated;
        private readonly IRepository<User> _repository;

        public void createUser(string name)
        {
            _repository.add(new User { name = name});
            _repository.save();

        }

        public void exportUsers(StreamWriter writer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getAllUsers()
        {
            throw new NotImplementedException();
        }

        public void importUsers(StreamReader reader)
        {
            throw new NotImplementedException();
        }

        public void removeUser(string name)
        {
            throw new NotImplementedException();
        }
    }
}
