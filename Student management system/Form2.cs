using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Student_management_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

     

      

       

        private void Button1_Click(object sender, EventArgs e)
        {
            
;    
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO student(firstname, lastname, dateofbirth, phnumber, fathername, fatheroccupation, mothername, motheroccupation, username, password) VALUES(@firstname, @lastname, @dateofbirth, @phnumber, @fathername, @fatheroccupation, @mothername, @motheroccupation, @username, @password)", con);
            if (firstname.Text != "" && lastname.Text != "" && dateofbirth.Text != "" && phonenumber.Text != "" && fathername.Text != "" && fatheroccupation.Text != "" && mothername.Text != "" && motheroccupation.Text != "" && username.Text != "" && createpassword.Text != "")
            {
                con.Open();
                SqlParameter p1 = new SqlParameter("@firstname", SqlDbType.NVarChar);
                SqlParameter p2 = new SqlParameter("@lastname", SqlDbType.NVarChar);
                SqlParameter p3 = new SqlParameter("@dateofbirth", SqlDbType.NVarChar);
                SqlParameter p4 = new SqlParameter("@phnumber", SqlDbType.NVarChar);
                SqlParameter p5 = new SqlParameter("@fathername", SqlDbType.NVarChar);
                SqlParameter p6 = new SqlParameter("@fatheroccupation", SqlDbType.NVarChar);
                SqlParameter p7 = new SqlParameter("@mothername", SqlDbType.NVarChar);
                SqlParameter p8 = new SqlParameter("@motheroccupation", SqlDbType.NVarChar);
                SqlParameter p9 = new SqlParameter("@username", SqlDbType.NVarChar);
                SqlParameter p10 = new SqlParameter("@password", SqlDbType.NVarChar);

                p1.Value = firstname.Text;
                p2.Value = lastname.Text;
                p3.Value = dateofbirth.Text;
                p4.Value = phonenumber.Text;
                p5.Value = fathername.Text;
                p6.Value = fatheroccupation.Text;
                p7.Value = mothername.Text;
                p8.Value = motheroccupation.Text;
                p9.Value = username.Text;
                p10.Value = createpassword.Text;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Regestered successully");
                con.Close();
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Enter all required Fields");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
