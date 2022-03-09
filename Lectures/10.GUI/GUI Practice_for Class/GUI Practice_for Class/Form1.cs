using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Practice_for_Class
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
            Class1 obj = new Class1();
        }

        private void btn_Active_Click(object sender, EventArgs e)
        {
            //  btn_enter.Enabled = true;
            
            picBox_pic1.Image = Image.FromFile("C:\\images.JFIF");
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            //  int a = 10;

            //    MessageBox.Show(txt_name.Text);
            //   MessageBox.Show(a.ToString());
            lstBox_name.Items.Add(txt_name.Text);
        }

        private void chkbox_red_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_red.Checked)
            {
                btn_Active.Enabled = true;
            }

        }

        private void chkBox_green_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_green.Checked)
            {
                
                btn_enter.Enabled = true;
            }
        }
    }
}
