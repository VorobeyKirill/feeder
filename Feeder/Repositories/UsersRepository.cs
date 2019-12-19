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

        public void Update(User obj)
        {
        }

        public void Remove(int id)
        {
        }

        public User Find(int id)
        {
            return list.Find(c => c.id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return list;
        }
    }
}
