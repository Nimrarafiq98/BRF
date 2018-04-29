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
    public partial class Addstop : Form
    {
        public Addstop()
        {
            InitializeComponent();
        }

        private void cmdAddStop_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            server.addstop(txtStopName.Text);
            MessageBox.Show("Stop has been added");


            Server.Service1 myserver = new Server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getstops();
            dataGridView1.DataSource = bs;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addstop_Load(object sender, EventArgs e)
        {

        }

        private void txtStopName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStopName_Click(object sender, EventArgs e)
        {

        }
    }
}
