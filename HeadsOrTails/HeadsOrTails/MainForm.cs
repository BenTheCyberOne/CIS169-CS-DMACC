/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Heads Or Tails
 The user can show a picture of a coin's heads or tails side using buttons
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

namespace HeadsOrTails
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowHeadsButton_Click(object sender, EventArgs e) //When the user clicks the "Show Heads" Button, make the tails picture invisible and the heads picture visible
        {
            TailsPictureBox.Visible = false;
            HeadsPictureBox.Visible = true;
        }

        private void ShowTailsButton_Click(object sender, EventArgs e)//When the user clicks the "Show Tails" Button, make the tails picture visible and the heads picture invisible
        {
            HeadsPictureBox.Visible = false;
            TailsPictureBox.Visible = true;
           
        }

        private void ExitButton_Click(object sender, EventArgs e)//Close the program
        {
            this.Close();
        }
    }
}
