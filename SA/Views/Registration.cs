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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the Email");
                return;
            }
            if(textBox2.Text.Trim() == "" || (textBox2.Text != textBox3.Text))
            {
                MessageBox.Show("Password is missmatch or empty");
                return;
            }
            
            int ro = comboBox1.SelectedIndex;
            Roles role;
            if (ro == -1)
            {
                MessageBox.Show("Please select a role");
                return;
            }
            if(ro == 0)
            {
                role = Roles.cashier;
            }
            else
            {
                role = Roles.customer;
            }
            if(RegistrationController.Registration(textBox1.Text, textBox2.Text, role))
            {
                MessageBox.Show("User Created Successfull");
            }
            else
            {
                MessageBox.Show("Error Occured Contact Administrators");
            }

        }
    }
}
