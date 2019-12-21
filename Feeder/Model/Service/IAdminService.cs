using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IAdminService : IService
    {
        IEnumerable<User> Users { get; set; }
        IEnumerable<FeederEntity> Feeders { get; set; }
        IEnumerable<string> Requests { get; set; }

        event Action UpdateRequests;
        event Action UpdateUsers;
        event Action UpdateFeeders;

        User SelectedUser { get; }
        FeederEntity SelectedFeeder { get; }
        void SetSelectedUser(string userName);
        void SetSelectedFeeder(string feederName);
    }
}
