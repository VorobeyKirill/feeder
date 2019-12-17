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
        private IUserLoginView _view;
        private IUserLoginService _service;
        public UserLoginPresenter(IKernel kernel, UserLoginService service, IUserLoginView view)
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
}
