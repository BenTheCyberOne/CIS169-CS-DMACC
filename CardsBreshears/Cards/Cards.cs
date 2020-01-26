/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Cards Function Demo
 The user can select from a list of cards and click a button to show it
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
using System.Windows.Forms;

namespace Cards
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }
        private void ShowCard(string card)
        {
            switch (card)//Based on what the user has selected, execute the respective function
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;
                case "10 of Hearts":
                    ShowTenHearts();
                    break;
                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }
        private void ShowAceSpades()//show only the Ace of Spades card
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void ShowTenHearts()//show only the Ten of Hearts card
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        private void ShowKingClubs()//show only the King of Clubs card
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }



        private void showCardButton_Click(object sender, EventArgs e)//if the user has selected an item from the list box, send it as a string to a function
        {
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a card from" + "the list box");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
