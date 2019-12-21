using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Model.Repository
{
    public class UserRepository : IRepository<User>
    {
        private static List<User> _data = new List<User>();
        private static int _end_index = 0;
        public int Add(User obj)
        {
            foreach (var user in _data)
            {
                if (user.Name == obj.Name)
                {
                    throw new ArgumentException("User is already exist, please choose another name!");
                }
            }
            obj.Id = _end_index;
            _end_index++;
            _data.Add(obj);
            return obj.Id;
        }

        public bool CheckForOverlaps(User user)
        {
            foreach (var man in _data)
            {
                if (man.Name == user.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public User Find(string Name)
        {
            return _data.Find(c => c.Name == Name);
        }

        public IEnumerable<User> GetAll()
        {
            return _data;
        }

        public void Update(User obj)
        {
        
        }
    }
}
