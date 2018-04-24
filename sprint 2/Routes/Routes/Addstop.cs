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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Addstop_Load(object sender, EventArgs e)
        {

        }
    }
}
