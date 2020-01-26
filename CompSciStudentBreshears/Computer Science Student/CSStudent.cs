/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Computer Science Student Form
 The user can input a CS Student's details and view the required hours
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
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class CSStudent : Form
    {
        public CSStudent()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)//grab the hours and set the student information from the user field inputs
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
            string name, id, track;
            if (r.IsMatch(nameTextBox.Text) || r.IsMatch(idTextBox.Text))
            {
                MessageBox.Show("Please enter valid characters only");
            }
            else if (nameTextBox.Text == "" || idTextBox.Text == "")
            {
                MessageBox.Show("Please enter a name and ID");
            }
            else
            {
                name = nameTextBox.Text;
                id = idTextBox.Text;
                if (infoSystemsRadioButton.Checked)
                {
                    track = "Information Systems";
                }
                else
                {
                    track = "Software Engineering";
                }

                CompSciStudent csStudent = new CompSciStudent(name, id, track);
                requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)//clear the GUI
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            requiredHoursLabel.Text = "";
        }
    }
}
