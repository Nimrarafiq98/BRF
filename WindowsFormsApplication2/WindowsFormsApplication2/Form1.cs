using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRegistration_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool isvalid;
            bool isvalidPassed;
            Server.isvalid(txtUsername.Text, txtPassword.Text, out isvalid, out isvalidPassed);
            if (isvalid)
            {
                MessageBox.Show("valid user!");
            }
            else
            {
                MessageBox.Show("invalid user!");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset reset = new Reset();
            this.Hide();
            reset.Show();
           
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
