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
        private readonly IAdminView _adminView;
        private IKernel _kernel;

        public AdminPresenter(IKernel kernel, AdminService adminService, IAdminView view)
        {
            _kernel = kernel;
            _adminService = adminService;
            _adminView = view;
            _adminView.registerNewUser += RegisterNewUser;
        }

        public void RegisterNewUser(string name)
        {
            var user = new User();
            user.name = name;
            _adminService.RegisterUser(user);
        }

        public void Run()
        { 
            _adminView.Show();
        }
    }
}
