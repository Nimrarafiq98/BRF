using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Newuser u = new Newuser();
            u.Username = txtUsername.Text;
            u.Password = txtPassword.Text;
            UserDataClass.usersArrayList.Add(u);

            txtUsername.Text = "";
            txtPassword.Text = "";
            MessageBox.Show("User has been registered");

        }

        private void lnkRegisteration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l =Login.getinstance();
            l.Show();
        }
    }
}
