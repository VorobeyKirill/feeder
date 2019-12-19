using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T> where T : class
    {

        int Add(T obj);
        T Find(int id);
        IEnumerable<T> GetAll();

    }
}
