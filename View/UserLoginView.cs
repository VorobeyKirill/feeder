﻿using Presenter.Forms;
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
        public UserLoginView()
        {
            InitializeComponent();
        }

        public string UserName => throw new NotImplementedException();

        public event Action SignIn;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
