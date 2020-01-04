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
        event Action UpdateFeeders;
        User CurrentUser { get; set; }

        void RegisterUser(User user);
        void AddFeeder(FeederEntity feeder, string userName);
        User Find(string userName);
        List<FeederEntity> GetFeeders(string userName);
    }
}
