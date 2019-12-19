using Feeder.Presentation;
using Model.Service;
using Ninject;
using Presenter.Forms;

namespace Feeder.Presenter.Implementations
{
    public class AdminPresenter : IAdminPresenter
    {
        private IAdminView adminView;
        private readonly IAdminService _adminService;
        private readonly IAdminView _adminView;
        private IKernel _kernel;

        public AdminPresenter(IAdminView adminView)
        {
            this.adminView = adminView;
        }

        public AdminPresenter(IKernel kernel, IAdminService adminService, IAdminView view)
        {
            _kernel = kernel;
            _adminService = adminService;
            _adminView = view;
        }

        public void Run()
        {
            
            _adminView.Show();
            
        }
    }
}
