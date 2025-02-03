using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GtifindoLeaveManagementEmployee
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            DBConnection db = new DBConnection();
            bool isValidUser = db.ValidateUser(username, password);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!");
                // Proceed with the application logic, maybe open the main form
                Main mainForm = new Main();  // Create an instance of the Main form
                this.Hide();
                mainForm.Show();  // Show the Main form
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Optionally, confirm before closing
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();  // Closes the entire application
            }
        }
    }
}
