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
    public partial class Updatestop : Form
    {
        public Updatestop()
        {
            InitializeComponent();
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool updatestops;
            bool updatestopsPassed;
            server.updatestops(textBox1.Text,txtOldstopname.Text, txtnewstopname.Text, out updatestops, out updatestopsPassed);
            if (updatestops)
            {
                MessageBox.Show("stop updated");
                Server.Service1 myserver = new Server.Service1();
                BindingSource bs = new BindingSource();
                bs.DataSource = myserver.getstops(textBox1.Text);
                dataGridView1.DataSource = bs;
            }
            else
            {
                MessageBox.Show("stop not founded .Please enter valid stopname");
            }
        }
    }
}
