using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;
using StudentManagementSystem.Forms.Core;

namespace StudentManagementSystem.Forms.Auth
{
    public partial class AdminLogin : Form
    {
        //Connection String
        private readonly string connectionString = "DRIVER={MySQL ODBC 9.1 Unicode Driver};" +
                              "SERVER=localhost;" +
                              "DATABASE=smsdatabase;" +
                              "USER=root;" +
                              "PASSWORD=admin;";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            requestLogin(userTxt.Text, passTxt.Text);
        }

        //For login function
        private void requestLogin(String user, String pass)
        {
            string query = "SELECT COUNT(*) FROM superuser WHERE Username = ? AND Password = ?";
            var dbOperations = new DatabaseOperations(connectionString);
            var usernameParameter = new OdbcParameter("@Username", user);
            var passwordParameter = new OdbcParameter("@Password", pass);
            int count = dbOperations.ExecuteScalarQuery(query, usernameParameter, passwordParameter);
            if (count == 1)
            {
                AdminMain am = new AdminMain();
                this.Hide();
                am.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }

        private void backtologinBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.ShowDialog();
        }
    }
}
