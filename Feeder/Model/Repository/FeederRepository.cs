using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Entity;
using System.Threading.Tasks;

namespace Feeder.Model.Repository
{
    class FeederRepository : IRepository<FeederEntity>
    {
        private static List<FeederEntity> _data = new List<FeederEntity>();
        private static int _end_index = 0;
        public int Add(FeederEntity obj)
        {
           if(CheckForOverlaps(obj))
            {
                throw new ArgumentException("Please enter another feeder's name");
            }
            obj.Id = _end_index;
            _end_index++;
            _data.Add(obj);
            return obj.Id;
        }

        public bool CheckForOverlaps(FeederEntity obj)
        {
            foreach (var feeder in _data)
            {
                if (feeder.Name == obj.Name && feeder.Type == obj.Type)
                {
                    return true;
                }
            }
            return false;
        }

        public FeederEntity Find(string Name)
        {
            return _data.Find(c => c.Name == Name);
        }

        public IEnumerable<FeederEntity> GetAll()
        {
            return _data;
        }

        public void Update(FeederEntity obj)
        {

        }
    }
}
