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
    public partial class BorrowingA : Form
    {
        public BorrowingA()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");
        private void BorrowingA_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            SqlCommand cnn = new SqlCommand("Select * from borrowingtb", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Borrowingtb values(@id,@student_name,@book_name,@date_borrowed,@date_returned)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Student_Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Book_Name", textBox3.Text);

            cnn.Parameters.AddWithValue("@Date_Borrowed", DateTime.Parse(dateTimePicker1.Text));

            cnn.Parameters.AddWithValue("@Date_Returned", DateTime.Parse(dateTimePicker2.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("update Borrowingtb set Student_Name = @Student_Name, Book_Name = @Book_Name, Date_Borrowed = @Date_Borrowed, Date_Returned = @Date_Returned WHERE ID = @id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Student_Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Book_Name", textBox3.Text);

            cnn.Parameters.AddWithValue("@Date_Borrowed", DateTime.Parse(dateTimePicker1.Text));

            cnn.Parameters.AddWithValue("@Date_Returned", DateTime.Parse(dateTimePicker2.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("delete Borrowingtb where id = @id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

        }
    }
}
