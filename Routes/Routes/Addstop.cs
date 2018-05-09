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
            bool addstop;
            bool addstoppassed;
            server.addstop(textBox1.Text,txtStopName.Text,txtLongitude.Text,txtLatitude.Text,out addstop,out addstoppassed);
            if (addstop)
            {
                MessageBox.Show("Stop has been added");
                Server.Service1 myserver = new Server.Service1();
                BindingSource bs = new BindingSource();
                bs.DataSource = myserver.getstops(textBox1.Text);
                dataGridView1.DataSource = bs;

            }
            else
            {
                MessageBox.Show(" enter something");

            }
          
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

        private void button1_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            this.Hide();
            update.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Update update = new Update();
            this.Hide();
            update.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            this.Hide();
            search.Show();
        }
    }
}
