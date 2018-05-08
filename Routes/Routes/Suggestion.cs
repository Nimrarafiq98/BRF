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
    public partial class Suggestion : Form
    {
        public Suggestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool shortest;
            bool shortestpassed;
            server.shortest(textBox1.Text,textBox2.Text,out shortest,out shortestpassed);
            if (shortest)
            {
                MessageBox.Show(textBox1.Text);
            }

        }
    }
}
