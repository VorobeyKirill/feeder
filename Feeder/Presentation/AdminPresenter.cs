using Feeder.Presentation;
using Model.Entity;
using Model.Service;
using Ninject;
using Presenter.Forms;

namespace Feeder.Presenter.Implementations
{
    public class AdminPresenter : IAdminPresenter
    {
        private readonly IUserService _userService;
        private readonly IAdminView _adminView;
        private IKernel _kernel;

        public AdminPresenter(IKernel kernel, UserService userService, IAdminView view)
        {
            _kernel = kernel;
            _userService = userService;
            _adminView = view;
            _adminView.registerNewUser += RegisterNewUser;
        }

        public void RegisterNewUser(string name)
        {
            var user = new User();
            user.name = name;
            _userService.RegisterUser(user);
        }

        public void Run()
        { 
            _adminView.Show();
        }
    }
}
