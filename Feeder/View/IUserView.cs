using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.UserView;

namespace Presenter.Forms
{
    public interface IUserView : IView
    {
        event createfeeder createFeeder;
    }
}
