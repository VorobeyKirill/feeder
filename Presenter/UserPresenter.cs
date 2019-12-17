using Model.Service;
using Ninject;
using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class UserPresenter : AbstractPresenter
    {
        public UserPresenter(IKernel kernel, UserService service, IUserView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }
    }
}
