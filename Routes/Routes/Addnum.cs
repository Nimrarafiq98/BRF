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
            bool add;
            bool addpassed;
            server.addroute(txtBusNumber.Text, txtRouteNumber.Text,out add,out addpassed);
            if (add)
            {
                MessageBox.Show("Bus number and route number has been added");


                Server.Service1 myserver = new Server.Service1();
                BindingSource bs = new BindingSource();
                bs.DataSource = myserver.getbusroute();
                dataGridView1.DataSource = bs;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
            else
            {
                MessageBox.Show(" enter something");
            }

        }
        // add
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

        private void button1_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            this.Hide();
            update.Show();
        }

        private void Addnum_Load(object sender, EventArgs e)
        {

        }
    }
}
