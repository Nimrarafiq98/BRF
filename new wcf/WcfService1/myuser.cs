using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace WcfService1
{
    public class myuser
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string ConfirmPassword;

        public string ConfirmPassword1
        {
            get { return ConfirmPassword; }
            set { ConfirmPassword = value; }
        }

      


    }
}