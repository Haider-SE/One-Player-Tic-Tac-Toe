using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String name = txtboxusername.Text;
            String password = txtboxpassword.Text;
            if(name == "samia" && password == "password")
            {
                // MessageBox.Show("you have entered right username and password");
                this.Hide();
                main_frm form = new main_frm();
                form.Show();
            }
            else
            {
                MessageBox.Show("you have entered invalid username and password");
                txtboxusername.Clear();
                txtboxpassword.Clear();
            }

        }

    }
}
