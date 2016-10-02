using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA.Views
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminOrders ao1 = new AdminOrders();
            ao1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddItem ad1 = new AddItem();
            ad1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateItem ui1 = new UpdateItem();
            ui1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminReport adr2 = new AdminReport();
            adr2.Show();
        }
    }
}
