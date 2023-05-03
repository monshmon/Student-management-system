using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_management_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentmanagementsystemDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentmanagementsystemDataSet.student);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from student where password = '"+password2.Text+"';",con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("Select * from student where password='"+password2.Text+"';", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            password2.PasswordChar = '*';

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
