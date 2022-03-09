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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Haider\University\Semester 4\Study in Lock Down\VP\270-BSCS-18 Haider Ali Final Project VP\TicTacToe\Database.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            ////
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            ////
        }
        private void label2_Click(object sender, EventArgs e)
        {
            /////
        }

        private void label3_Click(object sender, EventArgs e)
        {
            /////
        }
        private void label4_Click(object sender, EventArgs e)
        {
            ////
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ///
            if (!string.IsNullOrEmpty(Player2Name.Text))
            button2.Enabled = !string.IsNullOrEmpty(Player1Name.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ///
            if (!string.IsNullOrEmpty(Player1Name.Text))
                button2.Enabled = !string.IsNullOrEmpty(Player2Name.Text);
        }

        public static string p1name;
        public static string p2name;
        public static string recby
        {
            get { return p1name; }
            set { p1name = value; }
        }
        public static string recby2
        {
            get { return p2name; }
            set { p2name = value; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(isvalid())
            {                
                string query = "SELECT * FROM Login WHERE Name = '" + Player1Name.Text + "'AND Password = '" + Player1Pass.Text + "'";
                string query1 = "SELECT * FROM Login WHERE Name = '" + Player2Name.Text + "'AND Password = '" + Player2Pass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                DataTable dta1 = new DataTable();
                sda1.Fill(dta1);
                if (dta.Rows.Count == 1 && dta1.Rows.Count == 1)
                    {                                          
                        this.Hide();
                        Multiplayer f2 = new Multiplayer();
                        f2.Show();
                    }
                else if(dta.Rows.Count != 1)
                {
                    MessageBox.Show("Enter Valid user name and id (Player 1)", "Error");
                }
                else if(dta1.Rows.Count != 1)
                {
                    MessageBox.Show("Enter Valid user name and id (Player 2)", "Error");
                }
            }           

        }
        private bool isvalid()
        {
            if(Player1Name.Text.TrimStart() == string.Empty)   
            {
                MessageBox.Show("Enter Valid user name and id", "Error");
                return false; 
            }
            else if(Player1Pass.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Valid user name and id", "Error");
                return false;
            }
            return true;                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }
    }
}
