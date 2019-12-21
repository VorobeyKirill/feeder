using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Model.Service
{
    class MakeRequestService : IMakeRequestService
    {
        public List<string> _data;
        public void AddRequest(User user, string message)
        {
            string request;
            request = string.Concat(user.Name + ": ", '"' +  message + '"');
            _data.Add(request);
        }
    }
}
