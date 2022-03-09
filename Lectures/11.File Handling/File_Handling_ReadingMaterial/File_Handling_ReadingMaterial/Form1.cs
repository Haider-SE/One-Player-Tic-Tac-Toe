using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Add for File Handling


namespace File_Handling_ReadingMaterial
{
    public partial class Form1 : Form
    {
        // for global access in class
        FileStream fs; // for file access
        StreamReader sr; // to read data from file
        StreamWriter sw; // to write data in file
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           OpenFileDlg.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDlg.ShowDialog();
        }

        private void OpenFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            path = OpenFileDlg.FileName;
            // operate for file reading process
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (sr.EndOfStream) 
           // while (str != null)
            {
                // Console.WriteLine(str);
                lstBox_show.Items.Add(str);
                str = sr.ReadLine();
            }
         //   Console.ReadLine();
            sr.Close();
            fs.Close();


        }

        private void SaveFileDlg_FileOk(object sender, CancelEventArgs e)
        {
            path = SaveFileDlg.FileName;
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            string str = txtBox_write.Text;
            sw.WriteLine(str);
            sw.Close();
            fs.Close();

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
