/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Student Structure
 The user can input the student's name, ID, and major and view them through a message box
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

namespace StudentStructureBreshears
{
    public partial class StudentStructure : Form
    {
        public StudentStructure()
        {
            InitializeComponent();
        }
        public struct Student//student constructor
        {
            public String name;
            public String id;
            public String major;
        }
        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)//create a new student object and set the values from the user input
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
            Student st = new Student//a new student with name, id and major from the user
            {
                name = nameTextBox.Text,
                id = idTextBox.Text,
                major = majorTextBox.Text
            };
            if (st.name.All(char.IsDigit) || (st.major.All(char.IsDigit)))//check if numbers are used in the name or major
            {
                MessageBox.Show("Error: Please input a valid name or major");
                st.name = "";
                st.major = "";
                nameTextBox.Text = "";
                majorTextBox.Text = "";
            }
            else if (r.IsMatch(nameTextBox.Text) || r.IsMatch(idTextBox.Text) || r.IsMatch(majorTextBox.Text))//make sure no special characters are typed
            {
                MessageBox.Show("Please input valid characters only!");
                nameTextBox.Text = "";
                idTextBox.Text = "";
                majorTextBox.Text = "";
            }
            else
            {
                displayStudent(st);
            }
        }
        private void displayStudent(Student st)//display the student information in a message box
        {
            MessageBox.Show("Student Name: " + st.name + "\nStudent ID: " + st.id + "\nStudent Major: " + st.major);
        }
    }

}
