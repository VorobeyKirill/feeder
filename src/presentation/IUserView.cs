using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    interface IUserView : IView
    {
        event Action GoBack;
        event Action<string> ImportFeeders;

        event Action<string> AddTimetable;
        event Action<string> RemoveTimetable;

        void ShowFeeder(IEnumerable<string> feeders);
        void ShowError(string message);
    }
}
