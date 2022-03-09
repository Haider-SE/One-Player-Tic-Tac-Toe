using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class SignUp : Form
    {
        //yahan data base ka connection kia ... is path ko change karlena ... mainvideo baijhun ga
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Haider\University\Semester 4\Study in Lock Down\VP\SnackGame\Snake\Database.mdf;Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (isvalid())
            {

                string query = "SELECT * FROM Login WHERE Username = '" + textBox1.Text + "'AND Password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count == 1)
                {

                   // tabControl1.TabPages.Remove(tabPage1);
                    this.Hide();
                    main_frm form = new main_frm();
                    form.Show();
                    
                }
                else
                {
                    MessageBox.Show("Enter Valid user name and id", "Error");
                }
            }
        }
        private bool isvalid()
        {
            if ((textBox1.Text.TrimStart() == string.Empty)||(textBox2.Text.TrimStart() == string.Empty))
            {
                MessageBox.Show("Enter Valid user name and id", "Error");
                return false;
            }
           
           
            
            return true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
