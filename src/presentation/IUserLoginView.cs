using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentation
{
    interface IUserLoginView : IView
    {
        string userName { get; set; }

        event Action<string> LogIn;
        event Action LogInAsAdmin;
    }
}
