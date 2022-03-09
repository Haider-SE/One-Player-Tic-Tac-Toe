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

namespace TicTacToe
{
    public partial class Signup : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Haider\University\Semester 4\Study in Lock Down\VP\270-BSCS-18 Haider Ali Final Project VP\TicTacToe\Database.mdf;Integrated Security=True");
        public Signup() 
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //passing all value of lable
            cmd.CommandText = "Insert into Login(Name,password) values('" + newplayername.Text + "','" + newplayerpass.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            newplayername.Text = "";
            newplayerpass.Text = "";
            Form1 f = new Form1();
            f.Show();
            this.Hide();
            MessageBox.Show("Player added");
        }
    }
}
