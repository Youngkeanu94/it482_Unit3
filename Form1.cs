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


namespace it482_Unit2_Michael_Peck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        { 
        
             
    }
        public static string username = "";
        public static string password = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-0ANVP6M\PLSWORK;Initial Catalog=Northwind;Integrated Security=True");
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"(local)\SQLEXPRESS";
                var database = "Northwind";
                var thisUsername = username;
                var thisPassword = password;
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
               database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Successful");
                    Form1 From1 = new Form1();
                    From1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
