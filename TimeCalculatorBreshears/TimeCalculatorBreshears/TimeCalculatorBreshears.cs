/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Time Calculator
 The user can enter an amount of seconds and calculate the number of days, hours, minutes and seconds it equals to.
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

namespace TimeCalculatorBreshears
{
    public partial class TimeCalculatorBreshears : Form
    {
        public TimeCalculatorBreshears()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)//This will take the user's input and run a while loop that will increase the corresponding counter until the seconds variable is below the threshold of the constant
        {
            int seconds;
            int daysCount = 0;
            int hoursCount = 0;
            int minutesCount = 0;
            if (int.TryParse(secondsTextBox.Text, out seconds))
            {
                while (seconds >= 86400)
                {
                    seconds = seconds - 86400;
                    daysCount++;
                }
                while (seconds >= 3600)
                {
                    seconds = seconds - 3600;
                    hoursCount++;
                }
                while (seconds >= 60)
                {
                    seconds = seconds - 60;
                    minutesCount++;
                }
                daysCalcLabel.Text = daysCount.ToString();
                hoursCalcLabel.Text = hoursCount.ToString();
                minutesCalcLabel.Text = minutesCount.ToString();
                secondsCalcLabel.Text = seconds.ToString();

            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)//This will clear the user's input and the "time table"
        {
            daysCalcLabel.Text = "";
            hoursCalcLabel.Text = "";
            minutesCalcLabel.Text = "";
            secondsCalcLabel.Text = "";
            secondsTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)//Exits the program
        {
            this.Close();
        }
    }
}
