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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(textBox2.Text);
            double price = Int32.Parse(textBox3.Text);
            string category = comboBox1.SelectedValue.ToString();
            string itemname = textBox3.Text;
            MessageBox.Show("New item added successfully!");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;



        }
    }
}
