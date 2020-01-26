/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Student Attendance C# Final
 The user can login (or create a user if they do not have an account) and select whether they attended a class or not. An admin can query each student or course for attendance information.
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

namespace CSFinalBreshears
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            // populate the combobox with courses (max of 4)
            Course one = new Course("C#");
            Course two = new Course("Cybersecurity Forensics");
            Course three = new Course("Introduction to Database");
            Course four = new Course("Introduction to OOP");
            courseComboBox.Items.Add(one.name);
            courseComboBox.Items.Add(two.name);
            courseComboBox.Items.Add(three.name);
            courseComboBox.Items.Add(four.name);
        }

        private void studentInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)// save the table
        {
            this.Validate();
            this.studentInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentInfoDBDataSet);

        }

        private void AdminPanel_Load(object sender, EventArgs e)// fill the table viewer object on load
        {
            this.studentInfoTableAdapter.Fill(this.studentInfoDBDataSet.StudentInfo);
        }

        private void exitButton_Click(object sender, EventArgs e)// exit the program
        {
            this.Close();
        }

        private void qAttendanceButton_Click(object sender, EventArgs e)// search attendance depending on class
        {
            if (courseComboBox.SelectedItem == null)//if a course hasn't been selected from the drop down box, notify the admin
            {
                MessageBox.Show("Please select a course to query attendance.");
            }
            else
            {
                int course = courseComboBox.SelectedIndex;
                if (course == 0)
                {
                    this.studentInfoTableAdapter.FillByCourse1(this.studentInfoDBDataSet.StudentInfo);
                }
                if (course == 1)
                {
                    this.studentInfoTableAdapter.FillByCourse2(this.studentInfoDBDataSet.StudentInfo);
                }
                if (course == 2)
                {
                    this.studentInfoTableAdapter.FillByCourse3(this.studentInfoDBDataSet.StudentInfo);
                }
                if (course == 3)
                {
                    this.studentInfoTableAdapter.FillByCourse4(this.studentInfoDBDataSet.StudentInfo);
                }
            }
        }

        private void qAllStudentsButton_Click(object sender, EventArgs e)// grab everything from the StudentInfoDB table and sort by last names
        {
            this.studentInfoTableAdapter.FillByStudents(this.studentInfoDBDataSet.StudentInfo);
        }

        private void qStudentButton_Click(object sender, EventArgs e)// search for a paticular student (last names only!)
        {
            Regex regex = new Regex(@"^[a-zA-Z ]*$");//for text only
            if (searchTextBox.Text == "" || regex.IsMatch(searchTextBox.Text) == false)
            {
                MessageBox.Show("Please enter a valid last name.");
            }
            else
            {
                this.studentInfoTableAdapter.FillByStudentSearch(this.studentInfoDBDataSet.StudentInfo, searchTextBox.Text);
            }
        }
    }
}
