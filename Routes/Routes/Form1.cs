using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            server.registration(txtUsername.Text, txtPassword.Text);
            MessageBox.Show("User Registered!");
        }

        private void lnklbllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();
        }
    }
}
