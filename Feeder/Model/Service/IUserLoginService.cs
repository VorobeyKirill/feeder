using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IUserLoginService : IService
    {
        bool CheckForUser(User user);
    }
}
