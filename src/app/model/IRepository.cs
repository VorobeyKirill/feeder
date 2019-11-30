using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public interface IRepository<T> where T: class
    {
        void add(T obj);
        void save();
    }
}
