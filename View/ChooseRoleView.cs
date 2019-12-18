using Presenter.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ChooseRoleView : Form, IChooseRoleView
    {
        private bool _isAdmin;
        public ChooseRoleView()
        {
            InitializeComponent();
        }

        public event Action ChooseAdmin;
        public event Action ChooseUser;

        public new void Show()
        {
        }
    }
}
