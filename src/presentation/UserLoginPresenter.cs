using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace presentation
{
    class UserLoginPresenter
    {
        private readonly IUserLoginView _view;
        private readonly IUserLoginService _service;
        public UserLoginPresenter(IUserLoginView view, IUserLoginService service)
        {
            _view = view;
            
            _service = service;

        }

        private void addUser(string name)
        {
            _service.createUser(name);
            _view.Close();
            

        }
    }
}
