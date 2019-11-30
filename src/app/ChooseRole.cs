using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class ChooseRole : Form
    {
        public ChooseRole()
        {
            InitializeComponent();
        }
        UserLogin login = new UserLogin();
        Admin admin = new Admin();
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
    
            login.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            admin.Show();
        }
    }
}
