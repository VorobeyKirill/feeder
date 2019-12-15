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
        public AdminPresenter(IKernel kernel, UserService userService, IAdmin view)
        {
            _kernel = kernel;
            _service = userService;
            _view = view;
        }
    }
}
