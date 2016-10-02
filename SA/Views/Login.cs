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
            }
        }
    }
}
