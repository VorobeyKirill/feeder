using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.UserLoginView;

namespace Presenter.Forms
{
    public interface IUserLoginView : IView
    {
        string UserName { get; }
        event login Login;
    }
}
