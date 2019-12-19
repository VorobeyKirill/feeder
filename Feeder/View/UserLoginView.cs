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
    public partial class UserLoginView : Form, IUserLoginView
    {
        private readonly ApplicationContext _context;
        public string UserName;
        public event Action Login;

        public UserLoginView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void Show()
        {
            //_context.MainForm = this;
            base.Show();
        }


        string IUserLoginView.UserName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLoginView_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Login?.Invoke();
        }
    }
}
