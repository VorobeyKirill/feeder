using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IUserService : IService
    {
        User CurrentUser { get; set; }

        void RegisterUser(User user);
    }
}
