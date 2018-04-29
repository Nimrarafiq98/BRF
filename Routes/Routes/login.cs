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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void cmdRegistration_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool isvalid;
            bool isvalidPassed;
            server.isvalid(txtUsername.Text, txtPassword.Text, out isvalid, out isvalidPassed);
            if (isvalid)
            {
                MessageBox.Show("valid user!");

                Addnum Addnum = new Addnum();
                this.Hide();
                Addnum.Show();  
            }
            else
            {
                MessageBox.Show("invalid user!");
            }

            
            
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 registration = new Form1();
            this.Hide();
            registration.Show();
        }

        private void lnkReset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset reset = new Reset();
            this.Hide();
            reset.Show();
        }

        private void lnkAddnum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void nimraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
