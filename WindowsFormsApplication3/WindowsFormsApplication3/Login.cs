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
    public partial class Login : Form
    {
        private static Login L = null;
        private Login()
        {
            InitializeComponent();
        }
        public static Login getinstance()
        {
            if (L == null)
            {
                L = new Login();
            }
            return L;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Boolean isfound = false;
            foreach(Newuser u in UserDataClass.usersArrayList)
            {
                if(u.Username == txtUsername.Text && u.Password == txtPassword.Text)
                {
                    isfound = true;
                }
            }
           if(isfound)
           {
               MessageBox.Show("Valid user");
           }
           else
           {
               MessageBox.Show("InValid user");
           }
        }
    }
}
