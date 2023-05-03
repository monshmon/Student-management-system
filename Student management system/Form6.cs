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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_management_system
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            if (firstname2.Text != "" && lastname2.Text != "" && dateofbirsth2.Text != "" && phnumber2.Text != "" && fathername2.Text != "" && fathername2.Text != "" && mothername2.Text != "" && motheroccuption2.Text != "" && username2.Text != "" && password2.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into student values('" + firstname2.Text + "','" + lastname2.Text + "','" + dateofbirsth2.Text + "','" + phnumber2.Text + "','" + fathername2.Text + "','" + fatherpoccupation2.Text + "','" + mothername2.Text + "','" + motheroccuption2.Text + "','" + username2.Text + "','" + password2.Text + "');", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added sucessfully");
                con.Close();
            }
            else {
                MessageBox.Show("Enter all required Fields");
            }
            
        


        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            if (firstname3.Text != "" && lastname3.Text != "" && dateofbirth3.Text != "" && phnumber3.Text != "" && fathername3.Text != "" && fathername3.Text != "" && mothername3.Text != "" && motheroccupation3.Text != "")
            {
                SqlCommand cmd = new SqlCommand("update student SET  firstname='" + firstname3.Text + "',lastname='" + lastname2.Text + "',dateofbirth='" + dateofbirth3.Text + "',phnumber='" + phnumber3.Text + "',fathername='" + fathername3.Text + "',fatheroccupation='" + fatheroccupation3.Text + "',mothername='" + mothername3.Text + "',motheroccupation='" + motheroccupation3.Text + "' WHERE student_id='" + studentid3.Text + "';",con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("modified sucessfully");
            }
            else
            {
                MessageBox.Show("Enter all required Fields");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            if (studentid4.Text !="")
            {
                SqlCommand cmd = new SqlCommand("delete from student where student_id='"+studentid4.Text+"';", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted sucessfully");
            }
            else
            {
                MessageBox.Show("Enter all required Fields");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }
    }
}
