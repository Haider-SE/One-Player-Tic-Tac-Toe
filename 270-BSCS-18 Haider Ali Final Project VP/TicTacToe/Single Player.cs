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
    public partial class Single_Player : Form
    {
        int pwins, AIwins;
        List<bool> buttonwasclicked;
        bool turn = true; // true = X turn, false = y turn
        int turn_count = 0;
        int firsttime;
        Random rand = new Random();
        List<Button> buttonofgame;
        int index;
        bool flag = false;
        public Single_Player()
        {
            InitializeComponent();
            loadbuttons();
        }
        private void button_click(object sender, EventArgs e)
        { 
            Button b = (Button)sender;
            
            b.Text = "X";
            turn_count++;
            turn = !turn;
            b.Enabled = false;
            firsttime = buttonofgame.IndexOf(b);
            
            checkforwinner();
            if(turn_count !=9)
            AI.Start();

        }
        private void AI_Tick(object sender, EventArgs e)
        {
            int a = index;
            if (buttonofgame.Count > 0)
            {
               if ((((A2.Text == "O") && (A3.Text == "O")) ||
              ((B1.Text == "O") && (C1.Text == "O")) ||
              ((B2.Text == "O") && (C3.Text == "O"))) && (A1.Enabled))
                {
                    index = 0;
                    buttonwasclicked[0] = false;
                }

                else if (((B2.Text == "O" && C2.Text == "O") ||
                   (A1.Text == "O" && A3.Text == "O")) && (A2.Enabled))
                {
                    index = 1;
                    buttonwasclicked[1] = false;
                }
                else if (((B2.Text == "O" && C1.Text == "O") ||
                   (A1.Text == "O" && A2.Text == "O") ||
                   (B3.Text == "O" && C3.Text == "O")) && (A3.Enabled))
                {
                    index = 2;
                    buttonwasclicked[2] = false;
                }

                else if (((B2.Text == "O" && B3.Text == "O") ||
                   (A1.Text == "O" && C1.Text == "O")) && (B1.Enabled))
                {
                    index = 3;
                    buttonwasclicked[3] = false;
                }

                else if (((A2.Text == "O" && C2.Text == "O") ||
                   (B1.Text == "O" && B3.Text == "O") ||
                   (A1.Text == "O" && C3.Text == "O") ||
                    (C1.Text == "O" && A3.Text == "O")) && (B2.Enabled))
                {
                    index = 4;
                    buttonwasclicked[4] = false;
                }

                else if (((B2.Text == "O" && B1.Text == "O") ||
                   (A3.Text == "O" && C3.Text == "O")) && (B3.Enabled))
                {
                    index = 5;
                    buttonwasclicked[5] = false;
                }

                else if (((A1.Text == "O" && B1.Text == "O") ||
                   (C2.Text == "O" && C3.Text == "O") ||
                   (B2.Text == "O" && A3.Text == "O")) && (C1.Enabled))
                {
                    index = 6;
                    buttonwasclicked[6] = false;
                }

                else if (((B2.Text == "O" && A2.Text == "O") ||
                   (C1.Text == "O" && C3.Text == "O")) && (C2.Enabled))
                {
                    index = 7;
                    buttonwasclicked[7] = false;
                }

                else if (((B3.Text == "O" && A3.Text == "O") ||
                   (C1.Text == "O" && C2.Text == "O") ||
                   (A1.Text == "O" && B2.Text == "O")) && (C3.Enabled))
                {
                    index = 8;
                    buttonwasclicked[8] = false;
                }
                else if ((((A2.Text == "X") && (A3.Text == "X")) ||
                   ((B1.Text == "X") && (C1.Text == "X")) ||
                   ((B2.Text == "X") && (C3.Text == "X")))&&(A1.Enabled))
                    {
                        index = 0;
                    buttonwasclicked[0] = false;
                }

                    else if (((B2.Text == "X" && C2.Text == "X") ||
                       (A1.Text == "X" && A3.Text == "X")) && (A2.Enabled))
                    {
                        index = 1;
                    buttonwasclicked[1] = false;
                }
                    else if (((B2.Text == "X" && C1.Text == "X") ||
                       (A1.Text == "X" && A2.Text == "X") ||
                       (B3.Text == "X" && C3.Text == "X")) && (A3.Enabled))
                    {
                        index = 2;
                    buttonwasclicked[2] = false;
                }

                    else if (((B2.Text == "X" && B3.Text == "X") ||
                       (A1.Text == "X" && C1.Text == "X")) && (B1.Enabled))
                    {
                        index = 3;
                    buttonwasclicked[3] = false;
                }

                    else if (((A2.Text == "X" && C2.Text == "X") ||
                       (B1.Text == "X" && B3.Text == "X") ||
                       (A1.Text == "X" && C3.Text == "X") ||
                        (C1.Text == "X" && A3.Text == "X")) && (B2.Enabled))
                    {
                        index = 4;
                    buttonwasclicked[4] = false;
                }

                    else if (((B2.Text == "X" && B1.Text == "X") ||
                       (A3.Text == "X" && C3.Text == "X")) && (B3.Enabled))
                    {
                        index = 5;
                    buttonwasclicked[5] = false;
                }

                    else if (((A1.Text == "X" && B1.Text == "X") ||
                       (C2.Text == "X" && C3.Text == "X") ||
                       (B2.Text == "X" && A3.Text == "X")) && (C1.Enabled))
                    {
                        index = 6;
                    buttonwasclicked[6] = false;
                }

                    else if (((B2.Text == "X" && A2.Text == "X") ||
                       (C1.Text == "X" && C3.Text == "X")) && (C2.Enabled))
                    {
                        index = 7;
                    buttonwasclicked[7] = false;
                }

                    else if (((B3.Text == "X" && A3.Text == "X") ||
                       (C1.Text == "X" && C2.Text == "X") ||
                       (A1.Text == "X" && B2.Text == "X")) && (C3.Enabled))
                    {
                        index = 8;
                    buttonwasclicked[8] = false;
                }
              
                if (!flag || index == a)
                {
                    index = rand.Next(buttonofgame.Count);
                    while (!buttonwasclicked[index])
                        index = rand.Next(buttonofgame.Count);
                }
                    
                
                while(index == firsttime)
                {
                    index = rand.Next(buttonofgame.Count);
                }
                
                flag = true;
                try
                {
                    buttonofgame[index].Text = "O";                  
                    buttonofgame[index].Enabled = false;
                    buttonwasclicked[index] = false;
                    turn = !turn;
                    turn_count++;
                }
                catch
                {

                }
                    checkforwinner();
                    AI.Stop();                
            }   
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

                }
            }
            catch { }
        }
        private void loadbuttons()
        {
            buttonofgame = new List<Button> { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            buttonwasclicked = new List<bool> { true, true, true, true, true, true, true, true, true };
           
        }
        private void checkforwinner()
        {
            bool winner = false;
            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
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
                AI.Stop();
                
                String win = "";
                if (turn)
                    win = "O";
                else
                    win = "X";

                MessageBox.Show(win + "wins");
                AI.Stop();
                if (win=="X")
                {
                    pwins++;
                    PlayerWinBox.Text = pwins.ToString();
                    AI.Stop();
                }
                else if(win=="O")
                {
                    AIwins++;
                    AIwinbox.Text = AIwins.ToString();
                }
                AI.Stop();
                disabledbutton();
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("Draw");
                    AI.Stop();
                    disabledbutton();
                    
                }
                    
            }
        }
        private void Single_Player_Load(object sender, EventArgs e)
        {

        }
       

       
       
        private void disabledbutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }


        private void newGameToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    
                }
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
