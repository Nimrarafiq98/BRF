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
            bool registration;
            bool registrationpassed;
            server.registration(txtUsername.Text, txtPassword.Text,comboBox1.Text,out registration,out registrationpassed);
            if (registration)
            {

                MessageBox.Show(" Registered!");
            }
            else
            {
                MessageBox.Show(" enter something");
            }
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }
    }
}
