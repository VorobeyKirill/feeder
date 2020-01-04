using System;
using System.Collections.Generic;
using System.Linq;
using Feeder.Model.Service;
using Feeder.Presentation;
using Model.Entity;
using Model.Service;
using Ninject;
using Presenter.Forms;

namespace Feeder.Presenter.Implementations
{
    public class AdminPresenter : IAdminPresenter
    {
        private readonly IAdminService _adminService;
        private readonly IUserService _userService;
        private readonly IFeederService _feederService;
        private readonly IAdminView _adminView;
        private IKernel _kernel;

        public AdminPresenter(IKernel kernel, IAdminService adminService, IUserService userService, IFeederService feederService, IAdminView view) : base()
        {
            _kernel = kernel;
            _adminService = adminService;
            _userService = userService;
            _feederService = feederService; 
            _adminView = view;

            _adminView.registerNewUser += RegisterNewUser;
            _adminView.ClickAddFeeder += AddFeeder;

            _adminService.UpdateUsers += () => UpdateUsers();
            _adminService.UpdateFeeders += () => UpdateFeeders();
            _adminService.UpdateRequests += () => UpdateRequests();
        }

        private void AddFeeder(string name, string userName, string type)
        {
            var feeder = new FeederEntity(name, userName, type);
            _feederService.AddFeeder(feeder);
            _userService.AddFeeder(feeder, userName);
        }

        public void RegisterNewUser(string name)
        {
            var user = new User();
            user.Name = name;
            _userService.RegisterUser(user);
        }

        public void UpdateUsers()
        {
            _adminView.UpdateUsers(_adminService.Users.Select(u => u.Name).ToList());
        }

        private void UpdateRequests()
        {
        }

        private void UpdateFeeders()
        {
            _adminView.UpdateFeeders(_adminService.SelectedUser.Feeders.Select(f => f.Name).ToList());

        }
        private void UpdateFeeders(string userName)
        {
            
        }

        public void Run()
        { 
            _adminView.Show();
        }
    }
}
