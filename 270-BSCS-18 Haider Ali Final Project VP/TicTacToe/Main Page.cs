using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    //The information about the types of the game is given on this page, that includes Single or Multiplayer
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //ignored
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ignored
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is a button which takes the user to a single player game in which he plays against AI
            this.Hide();
            Single_Player S1 = new Single_Player();
            S1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this is a button which thakes the user to a multiplayer game in which he plays against another player.
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
