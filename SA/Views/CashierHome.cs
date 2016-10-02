using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA.Controllers;
using SA.Models;

namespace SA.Views
{
    public partial class CashierHome : Form
    {
        private CashierHomeController cashierHomeController = new CashierHomeController();
        private Order selectedOrder;

        public CashierHome()
        {
            InitializeComponent();
            tblPendingOrders.DataSource = cashierHomeController.getIncompleteOrders();
            tblPendingOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblPendingOrders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tblPendingOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            tblPendingOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Complete Order
            if(selectedOrder != null)
            {
                cashierHomeController.completeOrder(selectedOrder);
            }
            else
            {
                MessageBox.Show("No Order Selected! Please select an Order.");
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.Show();
        }

        private void tblPendingOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedOrder = tblPendingOrders.SelectedRows[0].DataBoundItem as Order;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cashierHomeController.seedData();
        }
    }
}
