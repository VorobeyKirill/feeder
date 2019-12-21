using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Model.Service
{
    public interface IMakeRequestService : IService
    {
        void AddRequest(User user, string message);
    }
}
