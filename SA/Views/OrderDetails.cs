using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA.Models;

namespace SA.Views
{
    public partial class OrderDetails : Form
    {
        public SA.Models.Order order;

        public OrderDetails(SA.Models.Order _order)
        {
            InitializeComponent();
            order = _order;
            tblOrderDetails.DataSource = order.orderItems;

            tblOrderDetails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblOrderDetails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblOrderDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void tblOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
