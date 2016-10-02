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
    public partial class AdminReport : Form
    {
        private CashierHomeController cashierHomeController = new CashierHomeController();
        private Order selectedOrder;

        public AdminReport()
        {
            InitializeComponent();

            AdminReportController adf = new AdminReportController();
            dataGridView1.DataSource = adf.getIncompleteOrders();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}