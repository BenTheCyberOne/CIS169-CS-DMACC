/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Days Of The Week
 The user can input an integer and be given the corresponding day of the week
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

namespace Switch_Example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)//Try to parse the user's input to an integer, if we can, set a case to compare it to the correct weekday and return the result
        {
            int number;

            
            if (int.TryParse(numberTextBox.Text, out number))
            {
                
                switch (number)
                {
                    case 1:
                        dayOfWeekLabel.Text = "Sunday";
                        break;
                    case 2:
                        dayOfWeekLabel.Text = "Monday";
                        break;
                    case 3:
                        dayOfWeekLabel.Text = "Tuesday";
                        break;
                    case 4:
                        dayOfWeekLabel.Text = "Wednesday";
                        break;
                    case 5:
                        dayOfWeekLabel.Text = "Thursday";
                        break;
                    case 6:
                        dayOfWeekLabel.Text = "Friday";
                        break;
                    case 7:
                        dayOfWeekLabel.Text = "Saturday";
                        break;
                    default:
                        MessageBox.Show("Please insert a value between 1 and 7");
                        break;
                }
            }
            else
            {
 
                MessageBox.Show("Please enter a valid integer");//
            }
        }

        private void exitButton_Click(object sender, EventArgs e)//Exit the program
        {
            this.Close();
        }
    }
}
