using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//for file access


namespace GUI_Practice
{
    public partial class Form1 : Form
    {
        //global access
        FileStream fs;//for file access
        StreamReader sr;//to read data from file
        StreamWriter sw;//to write data in file
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void option1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Enabled)
            {
                Enter.Enabled = true;
                OpenPicture.Enabled = true;
            }
            if(checkBox2.Checked == false)
            {
                pictureBox1.Visible = false; 
                Enter.Enabled = false;
                OpenPicture.Enabled = false;
            }
        }

        private void OpenPicture_Click(object sender, EventArgs e)
        {
            if (OpenPicture.Enabled)
            {
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Visible)
            {
                Open.Enabled = true;
                Open.BackColor = Color.DarkRed; 
                Save.Enabled = true;
                Save.BackColor = Color.DarkRed;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = openFileDialog1.FileName;
            //operate for file reading process
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while(str!=null)
            {
                listBox1.Items.Add(str);
                comboBox1.Items.Add(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
           
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            
        }

        private void option2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            path = saveFileDialog1.FileName;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            string str = textBox1.Text;
            sw.WriteLine(str);
            sw.Close();
            fs.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void option3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
