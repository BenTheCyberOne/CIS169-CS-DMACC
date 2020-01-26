/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Production Worker Class
 The user can input employee information and view it's created object information
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkerClass
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)//close the program
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)//create the production worker object 
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
            Regex r2 = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,<>/?[\]""_-]");//regex to validate input for the payrate field

            string name, shiftType;
            int num, shiftNum;
            double payRate;
            if (nameTextBox.Text == "" || numTextBox.Text == "" || payTextBox.Text == "")
            {
                MessageBox.Show("Please enter an employee name, employee number, and hourly rate");
            }
            else if (r.IsMatch(nameTextBox.Text) || r.IsMatch(numTextBox.Text) || nameTextBox.Text.All(char.IsDigit) || (numTextBox.Text.All(char.IsDigit) == false))
            {
                MessageBox.Show("Please input valid characters");
            }
            else if (r2.IsMatch(payTextBox.Text) || (Double.TryParse(payTextBox.Text, out double i) == false))
            {
                MessageBox.Show("Please input a valid payrate (do not include the $ symbol)");
            }
            else
            {
                name = nameTextBox.Text;
                num = Convert.ToInt32(numTextBox.Text);
                if (nightRadioButton.Checked)
                {
                    shiftNum = 2;
                }
                else
                {
                    shiftNum = 1;
                }
                payRate = Convert.ToDouble(payTextBox.Text);
                ProductionWorker pw = new ProductionWorker(name, num, shiftNum, payRate);// new Production Worker with the corresponding attributes
                MessageBox.Show("Current Production Worker Information:\nName: " + pw.empName + "\nEmployee Number: " + pw.empNum + "\nShift Status: " + pw.shiftType + "\nPay Rate: " + pw._payRate);
            }

        }
    }
}
