using Feeder.Presentation;
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
    public class UserPresenter : IUserPresenter
    {
        private IKernel _kernel;
        private IAdminService _service;
        private IUserView _view;

        public UserPresenter(IKernel kernel, IAdminService service, IUserView view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
            _view.createFeeder += createFeeder;
        }

        private void createFeeder(string type, string name)
        {
            var feeder = new FeederEntity();
            feeder.Type = type;
            feeder.Name = name;
        }

        public void Run()
        {
            _view.Show();
        }

    }
}
