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

namespace SA.Views
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tblOrder.DataSource =  OrderController.getOrder();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (OrderController.putItemintoOrder(1))
            {
                MessageBox.Show("Item Added to the List");
            }
            setOrder();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (OrderController.putItemintoOrder(2))
            {
                MessageBox.Show("Item Added to the List");
            }
            setOrder();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (OrderController.putItemintoOrder(3))
            {
                MessageBox.Show("Item Added to the List");
            }
            setOrder();
        }
        private void setOrder()
        {
            List<FoodItemDTO> list = new List<FoodItemDTO>();
            List<SA.Models.OrderItem> items = OrderController.getOrder().orderItems;
            float totla = 0;
            foreach (SA.Models.OrderItem a in items)
            {
                list.Add(new FoodItemDTO { itemName = a.foodItem.itemName, qty = a.qty });
                totla += a.foodItem.price;
            }
            tblOrder.DataSource = list;

            txtTotal.Text = System.Convert.ToString(totla);
        }
    }
    public class FoodItemDTO
    {
        public string itemName;
        public int qty;
        
    }
}
