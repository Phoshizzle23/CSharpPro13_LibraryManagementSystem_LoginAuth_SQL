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

namespace Library_Mgt_Sys
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;User ID=sa;Password=1234qwer");

        SqlCommand cmd;

        SqlDataReader dr;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Exit and wait 2 seconds before closing the form
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e) //Create account option Method
        {
            new Register().Show(); //Display register form
            this.Hide(); //Hide the login form
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e) //Show Password checkbox Method
        {
            if (checkbxShowPas.Checked) //If checkbox is checked - show password
            {
                userTxt.PasswordChar = '\0';
            }
            else //If the checkbox isn't checked - keep password hidden
            {
                passwordtxt.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e) // Login Btn
        {
            cmd = new SqlCommand("select * from usertb where username=@username and userpass=@userpass", con);
            cmd.Parameters.AddWithValue("@username", userTxt.Text);
            cmd.Parameters.AddWithValue("@userpass", passwordtxt.Text);

            con.Open();

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Login Successful!");
                Hide(); //This Form
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful!");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Clear button
        {
            userTxt.Text = ""; //Clears the username field
            passwordtxt.Text = ""; //Clears the password field
            userTxt.Focus(); //Set the curser back to username field
        }
    }
}
