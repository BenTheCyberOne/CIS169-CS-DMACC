/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Controls And Compound Conditions
 The user can select a city and check a checkBox, then the click of a button will determine if the checkBox was marked and what city the timezone is located in with if statements.
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

namespace ControlsAndCompoundConditionBreshears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) //First we check if user has "checked" the submitCheckBox, then we see if the user has selected an item. If so, set the item to a string and reply with correct information
        {
            string city;
            if (submitCheckBox.Checked == true) {
                if (cityListBox.SelectedIndex != -1)
                {
                    city = cityListBox.SelectedItem.ToString();
                    if (String.Compare(city, "Denver") == 0)
                    {
                        timeZoneLabel.Text = city;
                    }
                    if (String.Compare(city, "Honolulu") == 0)
                    {
                        timeZoneLabel.Text = city;
                    }
                    if (String.Compare(city, "Minneapolis") == 0)
                    {
                        timeZoneLabel.Text = city;
                    }
                    if (String.Compare(city, "New York") == 0)
                    {
                        timeZoneLabel.Text = city;
                    }
                    if (String.Compare(city, "San Francisco") == 0)
                    {
                        timeZoneLabel.Text = city;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a city");//If no item is selected
                }
            }
            else
            {
                MessageBox.Show("The checkbox must be checked!");//If checkbox isnt checked
            }
        }

        private void exitButton_Click(object sender, EventArgs e)//Exit the program
        {
            this.Close();
        }
    }
}
