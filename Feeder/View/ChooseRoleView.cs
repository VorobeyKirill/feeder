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
        private readonly ApplicationContext _applicationContext;
        public ChooseRoleView(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;   
            InitializeComponent();
        }

        public event Action ChooseAdmin;
        public event Action ChooseUser;


        public new void Show()
        {
            _applicationContext.MainForm = this;
            base.Show();
        }

        // choose user
        private void SelectUser_Click(object sender, EventArgs e)
        {
            ChooseUser?.Invoke();
        }

        // choose admin
        private void SelectAdmin_Click(object sender, EventArgs e)
        {
            ChooseAdmin?.Invoke();
        }
    }
}
