﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Forms
{
    public interface IChooseRoleView : IView
    {
        event Action ChooseAdmin;
        event Action ChooseUser;
    }
}
