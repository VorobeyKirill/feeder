using Model.Entity;
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

            (_view as IUserLoginView).Login += SignIn;
        }

        private void SignIn(string name)
        {
            var user = new User();
            user.name = name;
            bool test = _service.CheckForUser(user);
            if (_service.CheckForUser(user))
            {
               _kernel.Get<UserPresenter>().Run();
               _view.Close();
            }
         

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
