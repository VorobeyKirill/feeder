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
    public class ChooseRolePresenter : AbstractPresenter 
    {
        public ChooseRolePresenter(IKernel kernel, IChooseRoleService service, IChooseRoleView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            (_view as IChooseRoleView).ChooseAdmin += () => ChooseAdmin();
            (_view as IChooseRoleView).ChooseUser += () => ChooseUser();
        }

        private void ChooseAdmin()
        {
            _kernel.Get<AdminPresenter>().Run();
        }

        private void ChooseUser()
        {
            _kernel.Get<UserLoginPresenter>().Run();
        }
    }
}
