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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFinalBreshears
{
    public partial class UserExists : Form
    {
        public string studentName = "";
        public int studentID;
        public UserExists()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // cs is the data source path to the local database
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|StudentInfoDB.mdf; Integrated Security=True; Connect Timeout=30";
            SqlConnection connection = new SqlConnection(cs);//connect to the database
            // here we define multiple SQL commands so that we can set each course attended to either True or False (1 or 0)
            SqlCommand commandCourse1 = new SqlCommand("UPDATE StudentInfo SET course1 = @course1 WHERE studentID = @sID",connection);
            SqlCommand commandCourse2 = new SqlCommand("UPDATE StudentInfo SET course2 = @course2 WHERE studentID = @sID", connection);
            SqlCommand commandCourse3 = new SqlCommand("UPDATE StudentInfo SET course3 = @course3 WHERE studentID = @sID", connection);
            SqlCommand commandCourse4 = new SqlCommand("UPDATE StudentInfo SET course4 = @course4 WHERE studentID = @sID", connection);

            if (courseComboBox.SelectedItem == null)//if there is no course selected, alert the user
            {
                MessageBox.Show("Please select a course!");
            }
            int selectedCourse = courseComboBox.SelectedIndex;
            if (selectedCourse == 0 && attendedRadioButton.Checked == true)
            {
                commandCourse1.Connection.Open();
                commandCourse1.Parameters.AddWithValue("@course1", 1);
                commandCourse1.Parameters.AddWithValue("@sID", studentID);
                Console.WriteLine(commandCourse1.ExecuteNonQuery());//debugging only
                MessageBox.Show("Successfully submitted!");

                commandCourse1.Connection.Close();
                
            }
            else if (selectedCourse == 0 && noAttendedRadioButton.Checked == true)
            {
                commandCourse1.Connection.Open();
                commandCourse1.Parameters.AddWithValue("@course1", 0);
                commandCourse1.Parameters.AddWithValue("@sID", studentID);
                Console.WriteLine(commandCourse1.ExecuteNonQuery());//debugging only
                MessageBox.Show("Successfully submitted!");

                commandCourse1.Connection.Close();
            }
            else if (selectedCourse == 1 && attendedRadioButton.Checked == true)
            {
                commandCourse2.Connection.Open();
                commandCourse2.Parameters.AddWithValue("@course2", 1);
                commandCourse2.Parameters.AddWithValue("@sID", studentID);
                commandCourse2.ExecuteNonQuery();
                MessageBox.Show("Successfully submitted!");

                commandCourse2.Connection.Close();

            }
            else if (selectedCourse == 1 && noAttendedRadioButton.Checked == true)
            {
                commandCourse2.Connection.Open();
                commandCourse2.Parameters.AddWithValue("@course2", 0);
                commandCourse2.Parameters.AddWithValue("@sID", studentID);
                Console.WriteLine(commandCourse2.ExecuteNonQuery());//debugging only
                MessageBox.Show("Successfully submitted!");

                commandCourse2.Connection.Close();
            }
            else if (selectedCourse == 2 && attendedRadioButton.Checked == true)
            {
                commandCourse3.Connection.Open();
                commandCourse3.Parameters.AddWithValue("@course3", 1);
                commandCourse3.Parameters.AddWithValue("@sID", studentID);
                commandCourse3.ExecuteNonQuery();
                MessageBox.Show("Successfully submitted!");

                commandCourse3.Connection.Close();

            }
            else if (selectedCourse == 2 && noAttendedRadioButton.Checked == true)
            {
                commandCourse3.Connection.Open();
                commandCourse3.Parameters.AddWithValue("@course3", 0);
                commandCourse3.Parameters.AddWithValue("@sID", studentID);
                Console.WriteLine(commandCourse3.ExecuteNonQuery());//debugging only
                MessageBox.Show("Successfully submitted!");

                commandCourse3.Connection.Close();
            }
            else if (selectedCourse == 3 && attendedRadioButton.Checked == true)
            {
                commandCourse4.Connection.Open();
                commandCourse4.Parameters.AddWithValue("@course4", 1);
                commandCourse4.Parameters.AddWithValue("@sID", studentID);
                commandCourse4.ExecuteNonQuery();
                MessageBox.Show("Successfully submitted!");

                commandCourse4.Connection.Close();
            }
            else if (selectedCourse == 3 && noAttendedRadioButton.Checked == true)
            {
                commandCourse4.Connection.Open();
                commandCourse4.Parameters.AddWithValue("@course4", 0);
                commandCourse4.Parameters.AddWithValue("@sID", studentID);
                Console.WriteLine(commandCourse4.ExecuteNonQuery());//debugging only
                MessageBox.Show("Successfully submitted!");
                commandCourse4.Connection.Close();
            }

        }

        private void UserExists_Load(object sender, EventArgs e)//on load, show the user's first name as a greeting and set the course combo box
        {
            welcomeLabel.Text = ("Welcome, " + studentName + "!");
            Course one = new Course("C#");
            Course two = new Course("Cybersecurity Forensics");
            Course three = new Course("Introduction to Database");
            Course four = new Course("Introduction to OOP");
            courseComboBox.Items.Add(one.name);
            courseComboBox.Items.Add(two.name);
            courseComboBox.Items.Add(three.name);
            courseComboBox.Items.Add(four.name);
        }

        private void exitButton_Click(object sender, EventArgs e)// exit the program
        {
            this.Close();
        }
    }
}
