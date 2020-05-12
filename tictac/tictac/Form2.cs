﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictac
{
    public partial class Form2 : Form
    {


        int a1c = 0;
        int a2c = 0;
        int a3c = 0;
        int b1c = 0;
        int b2c = 0;
        int b3c = 0;
        int c1c = 0;
        int c2c = 0;
        int c3c = 0;

        bool looseCon = false;
        int wc;


        int turn = 1;



        public Form2()
        {
            InitializeComponent();
        }

        private void Aa1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                aa1.Enabled = false;
                a1c = 1;
                aa1.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                aa1.Enabled = false;
                a1c = 3;
                aa1.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            {
                a2.Enabled = false;
                a2c = 1;
                a2.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                a2.Enabled = false;
                a2c = 3;
                a2.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }
    

        private void A3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                a3.Enabled = false;
                a3c = 1;
                a3.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                a3.Enabled = false;
                a3c = 3;
                a3.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            {
                b1.Enabled = false;
                b1c = 1;
                b1.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";
                
            }
            else
            {
                b1.Enabled = false;
                b1c = 3;
                b1.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }            
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                b2.Enabled = false;
                b2c = 1;
                b2.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                b2.Enabled = false;
                b2c = 3;
                b2.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                b3.Enabled = false;
                b3c = 1;
                b3.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                b3.Enabled = false;
                b3c = 3;
                b3.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                c1.Enabled = false;
                c1c = 1;
                c1.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                c1.Enabled = false;
                c1c = 3;
                c1.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                c2.Enabled = false;
                c2c = 1;
                c2.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                c2.Enabled = false;
                c2c = 3;
                c2.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            {
                c3.Enabled = false;
                c3c = 1;
                c3.Text = "X";
                turn = turn * -1;
                P1Win();
                turnlabel.Text = "Player 2 Turn";

            }
            else
            {
                c3.Enabled = false;
                c3c = 3;
                c3.Text = "O";
                turn = turn * -1;
                P2Win();
                turnlabel.Text = "Player 1 Turn";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }




        private void P1Win()
        {
            int winCon = 0;

            if (a1c == 1 && a2c == 1 && a3c == 1)
            {
                winCon = 1;
            }
            else if (b1c == 1 && b2c == 1 && b3c == 1)
            {
                winCon = 1;
            }
            else if (c1c == 1 && c2c == 1 && c3c == 1)
            {
                winCon = 1;
            }
            else if (a1c == 1 && b1c == 1 && c1c == 1)
            {
                winCon = 1;
            }
            else if (a2c == 1 && b2c == 1 && c2c == 1)
            {
                winCon = 1;
            }
            else if (a3c == 1 && b3c == 1 && c3c == 1)
            {
                winCon = 1;
            }
            else if (a1c == 1 && b2c == 1 && c3c == 1)
            {
                winCon = 1;
            }
            else if (a3c == 1 && b2c == 1 && c1c == 1)
            {
                winCon = 1;
            }


            if (winCon == 1)
            {
                this.Hide();
                Form3 gotoWin = new Form3();
                gotoWin.ShowDialog();
                this.Close();
            }
            else if (a1c != 0 && a2c != 0 && a3c != 0 && b1c != 0 && b2c != 0 && b3c != 0 && c1c != 0 && c2c != 0 && c3c != 0)
            {
                this.Hide();
                Draw gotoDraw = new Draw();
                gotoDraw.ShowDialog();
                this.Close();
            }
        }

        


        private void P2Win()
        {
            if (a1c == 3 && a2c == 3 && a3c == 3)
            {
                looseCon = true;
            }
            else if (b1c == 3 && b2c == 3 && b3c == 3)
            {
                looseCon = true;
            }
            else if (c1c == 3 && c2c == 3 && c3c == 3)
            {
                looseCon = true;
            }
            else if (a1c == 3 && b1c == 3 && c1c == 3)
            {
                looseCon = true;
            }
            else if (a2c == 3 && b2c == 3 && c2c == 3)
            {
                looseCon = true;
            }
            else if (a3c == 3 && b3c == 3 && c3c == 3)
            {
                looseCon = true;
            }
            else if (a1c == 3 && b2c == 3 && c3c == 3)
            {
                looseCon = true;
            }
            else if (a3c == 3 && b2c == 3 && c1c == 3)
            {
                looseCon = true;
            }


            if (looseCon == true)
            {
                aa1.Enabled = false;
                a2.Enabled = false;
                a3.Enabled = false;
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                c1.Enabled = false;
                c2.Enabled = false;
                c3.Enabled = false;


                this.Hide();
                loose gotToLoose = new loose();
                gotToLoose.ShowDialog();
                this.Close();

            }
            else if (a1c != 0 && a2c != 0 && a3c != 0 && b1c != 0 && b2c != 0 && b3c != 0 && c1c != 0 && c2c != 0 && c3c != 0)
            {
                this.Hide();
                Form4 gotoDraw = new Form4();
                gotoDraw.ShowDialog();
                this.Close();
            }

        }


    }
}
