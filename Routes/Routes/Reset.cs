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
    public partial class Reset : Form
    {
        public Reset()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool reset;
            bool resetPassed;
            server.reset(txtUsername.Text, txtPassword1.Text, txtConfirmpassword.Text, out reset, out resetPassed);
            if (reset)
            {
                MessageBox.Show("Password match and reset ");
            }

            else
            {
                MessageBox.Show("user not found or password and confirm password mismatch");
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void lnkAddnum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
