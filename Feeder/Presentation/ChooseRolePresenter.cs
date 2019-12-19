using Feeder.Presentation;
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
    public class ChooseRolePresenter : IChooseRolePresenter
    {
        private IKernel _kernel;
        private IChooseRoleService _service;
        private IChooseRoleView _view;

        public ChooseRolePresenter(IKernel kernel, IChooseRoleService service, IChooseRoleView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            (_view as IChooseRoleView).ChooseAdmin += () => ShowAdminView();
            (_view as IChooseRoleView).ChooseUser += () => ShowUserView();
        }

        private void ShowAdminView()
        {
            _kernel.Get<AdminPresenter>().Run();
        }

        private void ShowUserView()
        {
            _kernel.Get<UserLoginPresenter>().Run();
        }
        public new void Run()
        {

            _view.Show();
        }
    }
}
