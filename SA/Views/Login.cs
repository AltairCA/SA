﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA.Controllers;
using SA.Views;
using SA.Helpers;
namespace SA.Views
{
    public partial class Login : Form
    {
        private LoginController loginController = new LoginController();

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            if(loginController.login(email, password))
            {
                // Move into Order/Admin/Cashier

                SA.Models.User regsitered = AppSession.getCurrentUser();
                this.Hide();
                if (regsitered.level == Models.Roles.owner)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else if(regsitered.level == Models.Roles.cashier)
                {
                    CashierHome cashierView = new CashierHome();
                   
                    cashierView.Show();
                }
                else
                {
                    Order orderView = new Order();
                    orderView.Show();
                }

                
            }
            else
            {
                MessageBox.Show("Failed to Login! Please Try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginController.seedData();
        }
    }
}
