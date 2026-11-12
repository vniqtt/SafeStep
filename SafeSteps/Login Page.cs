using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeSteps
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = loginPassIn(txtUsername.Text, txtPassword.Text);

            if (login)
            {
                MessageBox.Show(
                    "Welcome!",
                    "System",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Incorrect Password",
                    "System",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                );
            }
        }

        bool loginPassIn(string user, string password)
        {
            return user == "admin" && password == "1234";
        }
    }
}
