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

namespace Student_management_system
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Admiregester_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3BF7G3;Initial Catalog=studentmanagementsystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select count(*) from admin where admin_username='" + adminusername.Text + "' And admin_pasword='" + adminpassword.Text + "';", con);
            con.Open();
            cmd.ExecuteNonQuery();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                Form6 frm6 = new Form6();
                frm6.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Enter valid admin username and password");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
