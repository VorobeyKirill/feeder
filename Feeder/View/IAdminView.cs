using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static View.AdminView;

namespace Presenter.Forms
{
    public interface IAdminView
    {
        event registernewuser registerNewUser;

        void Show();
    }
}
