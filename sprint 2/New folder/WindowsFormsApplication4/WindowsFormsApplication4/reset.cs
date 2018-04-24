using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
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
            bool isvalid;
            bool isvalidPassed;
            Server.reset(txtUsername.Text, txtPassword.Text, out isvalid, out isvalidPassed);
            if (reset)
            {
                if (txtPassword != txtConfirmpassword)
                { MessageBox.Show("password mismatch"); }
                else
                {
                    MessageBox.Show("Password match");
                }
            }
            else
            {
                MessageBox.Show("user not found");
            }
        }
    }
}
