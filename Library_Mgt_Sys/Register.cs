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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Mgt_Sys
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;User ID=sa;Password=1234qwer");
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into usertb values(@username,@userpass)", con);

            cnn.Parameters.AddWithValue("@username", txtusername.Text);

            cnn.Parameters.AddWithValue("@userpass", txtpassword.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("User Saved");
        }

        private void clrbtn_Click(object sender, EventArgs e) // Clear button
        {
            txtusername.Text = ""; //Clears the username field
            txtpassword.Text = ""; //Clears the password field
            txtComPassword.Text = ""; //Clears the password field
            txtusername.Focus(); //Set the curser back to username field
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

            //Generate a random password
            var random = new Random();
            var password = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            //Set password fields to the generated password
            txtpassword.Text = password;
            txtComPassword.Text = password;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            // If the "Show Password" checkbox is checked, display the password characters in plain text
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else //Otherwise - hide the password characters
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }
    }
}
