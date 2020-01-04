using Feeder.Model.Service;
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
        private IUserService _userService;
        private IFeederService _feederService;
        private User _user;

        public UserPresenter(IKernel kernel, IAdminService service, IUserView view, IUserService userService, IFeederService feederService)
        {
            _kernel = kernel;
            _service = service;
            _userService = userService;
            _view = view;
            _view.createFeeder += createFeeder;
            _feederService = feederService;
            _userService.UpdateFeeders += () => UpdateFeeders(_user.Name);
        }

        private void UpdateFeeders()
        {
            _view.UpdateFeeders(_userService.CurrentUser.Feeders);
        }
        private void UpdateFeeders(string userName)
        {
            _view.UpdateFeeders(_userService.GetFeeders(userName));    
        }
        private void createFeeder(string type, string name)
        {
            var feeder = new FeederEntity();
            feeder.Type = type;
            feeder.Name = name;
        }

        public void Run(string userName)
        {
            _user = _userService.Find(userName);
            _view.Show();
            UpdateFeeders(_user.Name);

        }

    }
}
