using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Repositories
{
    class UsersRepository : IRepository<User>
    {
        private static List<User> list = new List<User>();
        private static int currentUserId = 0;
        public int Add(User obj)
        {
            foreach (var user in list)
            {
                if (user.name == obj.name)
                {
                    throw new ArgumentException("User is already exist, please choose another name!");
                }
            }
            obj.id = currentUserId;
            currentUserId++;
            list.Add(obj);
            return obj.id;
        }

        public User Find(string name)
        {
            return list.Find(c => c.name == name);
        }

        public bool CheckForUser(User user)
        {
            foreach (var man in list)
            {
                if (man.name == user.name)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<User> GetAll()
        {
            return list;
        }
    }
}
