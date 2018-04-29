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
    public partial class Addnum : Form
    {
        public Addnum()
        {
            InitializeComponent();
        }

        private void cmdAddnum_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            server.addroute(txtBusNumber.Text, txtRouteNumber.Text);
            MessageBox.Show("Bus number and route number has been added");

            Server.Service1 myserver = new Server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getbusroute();
            dataGridView1.DataSource = bs;

        }

        private void lnkAddStops_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Addstop Addstop = new Addstop();
            this.Hide();
            Addstop.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            if (e.ColumnIndex == 0)
            {
                Addstop addstop = new Addstop();
                addstop.Show();
            }
        }
    }
}
