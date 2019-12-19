using Model.Service;
using Ninject;
using Presenter.Forms;

namespace Presenter
{
    public class AdminPresenter : AbstractPresenter
    {
        private readonly IAdminService _service;
        private readonly IAdminView _view;
        public AdminPresenter(IKernel kernel, IAdminService adminService, IAdminView view)
        {
            _kernel = kernel;
            _service = adminService;
            _view = view;
        }

        public void Run()
        { 
            _view.Show();
        }
    }
}
