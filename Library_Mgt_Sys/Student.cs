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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");
        private void Student_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            SqlCommand cnn = new SqlCommand("Select * from studenttb", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into studenttb values(@id,@student_name,@age,@phone,@email)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Student_Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("delete studenttb where id = @id", con);

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
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5KJ157N\MATTDATABASEPRO;Initial Catalog=libraryMgtDb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("update studenttb set Student_Name = @Student_Name, Age = @Age, Phone = @Phone, Email = @Email WHERE ID = @id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Student_Name", textBox2.Text);

            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Phone", textBox4.Text);

            cnn.Parameters.AddWithValue("@Email", textBox5.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
