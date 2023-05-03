using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Student_management_system
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

      

        private void Button2_Click(object sender, EventArgs e)
        {
       
           
        
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 frm1= new Form2();
            frm1.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
         Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select count(*) from student where username=@username And password=@password;", con);

            new SqlParameter("@username", SqlDbType.NVarChar);
            new SqlParameter("@password", SqlDbType.NVarChar);
            con.Open();
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                Form3 next = new Form3();
                next.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter a valid user name and password ");
            }
            con.Close();
        }
    }
}

       