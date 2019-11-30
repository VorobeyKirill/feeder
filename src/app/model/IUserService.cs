using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public interface IUserLoginService
    {
        event Action UserUpdated;

        IEnumerable<string> getAllUsers();
        void importUsers(StreamReader reader);
        void exportUsers(StreamWriter writer);
        void createUser(string name);
        void removeUser(string name);
    }
}
