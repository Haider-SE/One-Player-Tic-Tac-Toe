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
    public partial class Multiplayer : Form
    {
        String win = "";
        int p1_wins, p2_wins;
        bool turn = true; // true = X turn, false = y turn
        int turn_count = 0;// to check to see if we have reached draw
        public Multiplayer()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            player1wins.Text = Form1.p1name;
            player2wins.Text = Form1.p2name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            //first we create a generic button and cast this generic object which is passed as a parameter as a button
            //thus making the sender object or casting the sender object as a button and storing it in b 
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            checkforwinner();
        }   
        private void checkforwinner()
        {
            bool winner = false;
            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
                winner = true;
            else if((C1.Text == C2.Text) && (C2.Text == C3.Text)&&(!C1.Enabled))
                winner = true;
            //veetical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;
            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;
           
            if (winner)
            {
                disabledbutton();
               
                if (turn)
                    win = "O";
                else
                    win = "X";
                MessageBox.Show(win + "wins");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw");
            }
            if (win == "X")
            {
                p1_wins++;
                player1wins.Text = p1_wins.ToString();
                
            }
            else if (win == "O")
            {
                p2_wins++;
                player2wins.Text = p2_wins.ToString();
            }
        }
        private void disabledbutton()
        {
            //we used try and catch method because it was giing an exception that we tried to cast our menu strip which is not a button
            //to a button so we got to have a runtime exception, we just need to catch the exception in catch block
            try
            {
                //control here is basically the enumeration or collection of all the controls on our windows form and we want to
                //apply some sort of evaluation for each control on our windows form
                foreach (Control c in Controls)
                {
                    //here we are converting generic object/contols in button
                    Button b = (Button)c;
                    //this will disbale each of the button
                    b.Enabled = false;
                }
            }
            catch { }  
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //we used try and catch method because it was giing an exception that we tried to cast our menu strip which is not a button
            //to a button so we got to have a runtime exception, we just need to catch the exception in catch block
            turn = true;
            turn_count = 0;
            try
            {
                //control here is basically the enumeration or collection of all the controls on our windows form and we want to
                //apply some sort of evaluation for each control on our windows form
                foreach (Control c in Controls)
                {
                    //here we are converting generic object/contols in button
                    Button b = (Button)c;
                    b.Enabled = true;
                    //this will enable each of the button
                    b.Text = "";
                    win = "";
                }
            }
            catch { }
        }
    }
}
