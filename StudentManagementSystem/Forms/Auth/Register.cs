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

namespace StudentManagementSystem.Forms.Auth
{
    public partial class Register : Form
    {
        private string connectionString = "DRIVER={MySQL ODBC 9.1 Unicode Driver};" +
                                  "SERVER=localhost;" +
                                  "DATABASE=smsdatabase;" +
                                  "USER=root;" +
                                  "PASSWORD=admin;";
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.ShowDialog();
        }

        private void backtologinBtn_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Dispose();
            l.ShowDialog();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text;
            string pass = passTxt.Text;
            string confpass = confpassTxt.Text;
            bool res = VerifyCredentials(user, pass, confpass);
            if (res)
            {
                RegisterRequest(user, pass);
                ClearAllFields();
            }
            {
                MessageBox.Show("Password and confirmation password must match!");
            }
        }

        private void ClearAllFields()
        {
            userTxt.Text = "";
            passTxt.Text = "";
            confpassTxt.Text = "";
        }
        private void RegisterRequest(String user, String pass)
        {
            string query = "INSERT INTO users (Username, Password)" +
                "VALUES (?, ?)";
            var dbOperations = new DatabaseOperations(connectionString);
            var userParameter = new OdbcParameter("Username", user);
            var passParameter = new OdbcParameter("Password", pass);
            dbOperations.ExecuteNonQuery(query, userParameter, passParameter);
            MessageBox.Show("User registration Successful");
        }

        private bool VerifyCredentials(String user, String pass, String confpass)
        {
            
            if (pass.Equals(confpass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
