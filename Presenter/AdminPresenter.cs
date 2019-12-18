using Model.Service.EntityService;
using Ninject;
using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class AdminPresenter : AbstractPresenter
    {
        private readonly IUserService _service;
        public AdminPresenter(IKernel kernel, IUserService userService, IAdminView view)
        {
            _kernel = kernel;
            _service = userService;
            _view = view;
        }
    }
}
