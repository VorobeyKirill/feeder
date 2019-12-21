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
    public partial class AdminView : Form, IAdminView
    {
        public string UserSelect { get => userSelect.Text; set => throw new NotImplementedException(); }
        public string FeederName { get => feederNameInput.Text; set => throw new NotImplementedException(); }



        public string FeederType;
        public delegate void registernewuser(string name);
        public delegate void clickaddfeeder(string name, string userName, string type);
        public event registernewuser registerNewUser;
        public event clickaddfeeder ClickAddFeeder;
        private readonly ApplicationContext _context;
        public AdminView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void Show()
        {
            //_context.MainForm = this;
            if(!Application.OpenForms.Cast<Form>().Any(f => f.Name == base.Name))
            {
                base.Show();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mainPage_Click(object sender, EventArgs e)
        {

        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            registerNewUser?.Invoke(userNameInput.Text);
        }

        private void userSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void requestsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addFeeder_Click(object sender, EventArgs e)
        { 
            ClickAddFeeder?.Invoke(feederNameInput.Text, userSelect.Text, FeederType);
        }

        private void dispencerFeeder_CheckedChanged(object sender, EventArgs e)
        {
            FeederType = "dispencer";
        }

        private void screwFeeder_CheckedChanged(object sender, EventArgs e)
        {
            FeederType = "screw";
        }

        public void UpdateUsers(IEnumerable<string> userNames)
        {
            userSelect.Items.Clear();
            foreach (var item in userNames)
            {
                userSelect.Items.Add(item);
            }
            
        }

        public void UpdateFeeders(IEnumerable<string> feederNames)
        {
            throw new NotImplementedException();
        }

        public void UpdateRequests()
        {
            throw new NotImplementedException();
        }
    }
}
