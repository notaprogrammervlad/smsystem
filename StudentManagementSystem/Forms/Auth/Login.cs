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
        public partial class Login : Form
        {
            private string connectionString = "DRIVER={MySQL ODBC 9.1 Unicode Driver};" +
                                  "SERVER=localhost;" +
                                  "DATABASE=smsdatabase;" +
                                  "USER=root;" +
                                  "PASSWORD=admin;";
            public Login()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AdminLogin al = new AdminLogin();
                this.Hide();
                al.ShowDialog();
            }

            private void registerToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Register r = new Register();
                this.Hide();
                r.ShowDialog();
            }

            private void Login_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }

            private void loginBtn_Click(object sender, EventArgs e)
            {
                requestLogin(userTxt.Text, passTxt.Text);
            }

            //For login function
            private void requestLogin(String user, String pass)
            {
                string query = "SELECT COUNT(*) FROM users WHERE Username = ? AND Password = ?";
                var dbOperations = new DatabaseOperations(connectionString);
                var usernameParameter = new OdbcParameter("@Username", user);
                var passwordParameter = new OdbcParameter("@Password", pass);
                int count = dbOperations.ExecuteScalarQuery(query, usernameParameter, passwordParameter);
                if (count == 1)
                {
                    Main m = new Main();
                    this.Hide();
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                }
            }

            private void Login_FormClosing(object sender, FormClosingEventArgs e)
            {

            }
    }
}