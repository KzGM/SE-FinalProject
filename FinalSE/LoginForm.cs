using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSE
{
    public partial class LoginForm : MaterialSkin.Controls.MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }
        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //ValidateUser();
        }
        private void ValidateUser()
        {
            string ConnectionString = @"Data Source=LAPTOP-1OHG4VJT;Initial Catalog=test_se;Integrated Security=True";
            string query = "SELECT role from UserData WHERE UserName = @username and Password=@password";
            string returnValue = "";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlcmd = new SqlCommand(query, con))
                {
                    sqlcmd.Parameters.Add("@username", SqlDbType.NVarChar).Value= txtUserName.Text;
                    sqlcmd.Parameters.Add("password", SqlDbType.NVarChar).Value = txtPassword.Text;
                    con.Open();
                    returnValue = (string)sqlcmd.ExecuteScalar();
                }
            }
            if (String.IsNullOrEmpty(returnValue))
            {
                MessageBox.Show("Incorrect Username or Password!");
                return;
            }
            returnValue = returnValue.Trim();
            if (returnValue == "Acc")
            {
                MessageBox.Show("You are logged in as an accountant");
                this.Hide();
            }   
            else if (returnValue == "Agent")
            {
                MessageBox.Show("You are logged in as a Agent");

                this.Hide();
            }
        }

        private void LoginForm_Leave(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
