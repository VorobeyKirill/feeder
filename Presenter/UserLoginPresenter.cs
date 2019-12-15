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
    public class UserLoginPresenter : AbstractPresenter
    {
        public UserLoginPresenter(IKernel kernel, UserLoginService service, ILoginUser view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

        }
    }
}
