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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.Service1 myserver = new Server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getbusroute();
            dataGridView1.DataSource = bs;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Server.Service1 my = new Server.Service1();
            bool postIDSepecified = true;
            if (e.ColumnIndex == 0)
            {
                Server.Route post = my.getdetail(e.RowIndex, postIDSepecified);
                Newnum pd = new Newnum(post);
                pd.Show();
            }
        }
    }
}
