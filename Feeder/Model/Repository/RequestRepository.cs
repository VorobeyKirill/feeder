using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Model.Repository
{
    class RequestRepository : IRepository<string>
    {
        List<string> _data = new List<string>();
        private int _end_pos = 0;
        public int Add(string obj)
        {
            _data.Add(obj);
            _end_pos++;
            return _end_pos;
        }

        public string Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAll()
        {
            return _data;
        }

        public void Save()
        {

        }

        public void Update(string obj)
        {
            throw new NotImplementedException();
        }
    }
}

