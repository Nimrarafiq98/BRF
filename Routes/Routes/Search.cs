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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Server.Service1 server = new Server.Service1();
            bool searchpick;
            bool searchpickpassed;
            server.searchpick(txtPickup.Text, out searchpick, out searchpickpassed);
         
            bool searchdown;
            bool searchdownpassed;
            server.searchdown(txtDropdown.Text,txtPickup.Text, out searchdown, out searchdownpassed);
            if (searchdown)
            {
                MessageBox.Show("route founded");
                Server.Service1 my = new Server.Service1();
                int distance;
                bool distancepassed;
                my.distance(txtPickup.Text,txtDropdown.Text,out distance,out distancepassed);
                if (distancepassed)
                {

                    Server.Service1 myserver = new Server.Service1();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = myserver.getsearch();
                    dataGridView1.DataSource = bs;
                    
                }
            } //jhjguxgs\ bind
            else
            {
                MessageBox.Show("route not founded");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suggestion sug = new Suggestion();
            this.Hide();
            sug.Show();
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
