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
    public class UserLoginPresenter : AbstractPresenter
    {
        private readonly IUserLoginView _view;
        private readonly IUserLoginService _service;
        public UserLoginPresenter(IKernel kernel, IUserLoginService service, IUserLoginView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            (_view as IUserLoginView).SignIn += () => SignIn();
        }

        private void SignIn()
        {
            // need user auth
            _kernel.Get<UserPresenter>().Run();

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
