using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    interface IAdminView : IView
    {
        event Action GoBack;
        event Action<string> ImportUsers;
        event Action<string> ExportUsers;
        event Action<string> ImportFeeders;
        event Action<string> ExportFeeders;
        event Action<string> AddFeeder;
        event Action<string> RemoveFeeder;
    }
}
