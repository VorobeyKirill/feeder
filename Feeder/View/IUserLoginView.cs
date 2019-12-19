using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Forms
{
    public interface IUserLoginView : IView
    {
        string UserName { get; }
        event Action SignIn;
    }
}
