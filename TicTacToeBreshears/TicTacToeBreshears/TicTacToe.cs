/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Tic-Tac-Toe Simulator
 The user can view a simulation of a Tic-Tac-Toe game
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeBreshears
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)//play the simulation
        {
            Random rnd = new Random();
            int[][] values = new int[3][] {new int[3], new int[3], new int[3] };//jagged 2d array with length of three, which creates the board
            //create an array of lists, used to set the text
            Label[] labels = new Label[9] {this.label1, this.label2, this.label3, this.label4, this.label5, this.label6, this.label7, this.label8, this.label9 };
            int labelcounter = 0;//used to place a X or O in each label
            int xwin = 0;//used to calculate total X wins
            int owin = 0;//used to calculate total O wins
            for (int x = 0; x < values.Length; x++)//using a nested loop, set the 2d array values
            {
                 for (int y = 0; y < values[x].Length; y++)
                {
                    int newRand = rnd.Next(0,2);//only pick 0 or 1
                    values[x][y] = newRand;
                    Console.WriteLine("Value is: " + values[x][y] + " at " + x + y); //this is used for debugging only!
                    if (values[x][y] == 0)//if a 0, make text O, otherwise it is an X
                    {
                        labels[labelcounter].Text = "O";
                        labelcounter++;
                    }
                    else
                    {
                        labels[labelcounter].Text = "X";
                        labelcounter++;
                    }
                }
            }
            CheckHorizontal(ref values, ref owin, ref xwin);
            CheckVertical(ref values, ref owin, ref xwin);
            CheckLeftToRight(ref values, ref owin, ref xwin);
            CheckRightToLeft(ref values, ref owin, ref xwin);
            CheckWinner(ref owin, ref xwin);
        }

        private void exitButton_Click(object sender, EventArgs e)//close the program
        {
            this.Close();
        }
        static void CheckHorizontal(ref int[][] values, ref int owin, ref int xwin)
        {
            int asum = 0;//used to calculate CheckHorizontal
            for (int i = 0; i < 3; i++)//horizontal check
            {
                for (int j = 0; j < 3; j++)
                {
                    asum += values[i][j];
                }
                if (asum == 0)
                {
                    owin++;
                    Console.WriteLine("O HAS WON HORIZON ASUM IS" + asum);//debug only!
                }
                else if (asum == 3)
                {
                    xwin++;
                    Console.WriteLine("X HAS WON HORIZON ASUM IS" + asum);//debug only!
                }
                else
                {
                    Console.WriteLine("TIE! ASUM IS" + asum);//debug only!
                }
                asum = 0;
            }
        }
        static void CheckVertical(ref int[][] values, ref int owin, ref int xwin)
        {
            int bsum = 0;//used to calculate CheckVertical
            for (int i = 0; i < 3; i++)//vertical check
            {
                for (int j = 0; j < 3; j++)
                {
                    bsum += values[j][i];
                }
                if (bsum == 0)
                {
                    owin++;
                    Console.WriteLine("O HAS WON VERTICAL BSUM IS" + bsum);//debug only!

                }
                else if (bsum == 3)
                {
                    xwin++;
                    Console.WriteLine("X HAS WON VERTICAL BSUM IS" + bsum);//debug only!
                }
                else
                {
                    Console.WriteLine("TIE! BSUM IS" + bsum);//debug only!
                }
                bsum = 0;
            }
        }
        static void CheckLeftToRight(ref int[][] values, ref int owin, ref int xwin)
        {
            int csum = 0;//used to calculate CheckLeftToRight
            int m = 0;//used for diagnal tests (see below)
            for (int i = 0; i < 3; i++)//diagonal 1 left to right check
            {
                csum += values[i][m];
                m++;
            }
            if (csum == 0)
            {
                owin++;
                Console.WriteLine("O HAS WON LEFTTORIGHT CSUM IS" + csum);//debug only!
            }
            else if (csum == 3)
            {
                xwin++;
                Console.WriteLine("X HAS WON LEFTTORIGHT CSUM IS" + csum);//debug only!
            }
            else
            {
                Console.WriteLine("TIE! CSUM IS" + csum);//debug only!
            }
        }
        static void CheckRightToLeft(ref int[][] values, ref int owin, ref int xwin)
        {
            int dsum = 0;//used to calculate CheckRightToLeft
            int m = 2;//used for diagnal tests (see below)
            for (int i = 0; i < 3; i++)//diagonal 2 right to left check
            {
                dsum += values[i][m];
                m--;
            }
            if (dsum == 0)
            {
                owin++;
                Console.WriteLine("O HAS WON RIGHTTOLEFT DSUM IS" + dsum);//debug only!
            }
            else if (dsum == 3)
            {
                xwin++;
                Console.WriteLine("X HAS WON RIGHTTOLEFT DSUM IS" + dsum);//debug only!
            }
            else
            {
                Console.WriteLine("TIE! DSUM IS" + dsum);//debug only!
            }
        }
        private void CheckWinner(ref int owin, ref int xwin)//check to see who won the game
        {
            if (owin > 0 && xwin > 0 || owin == 0 && xwin == 0)
            {
                winnerLabel.Text = ("TIE!");
            }
            if (owin > xwin)
            {
                winnerLabel.Text = ("O Wins!");
            }
            else
            {
                winnerLabel.Text = ("X Wins!");
            }
        }
    }
}
