using Model.Service;
using Ninject;
using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeder.Presenter.Implementations
{
    public class UserPresenter : AbstractPresenter
    {
        public UserPresenter(IKernel kernel, IUserService service, IUserView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }

    }
}
