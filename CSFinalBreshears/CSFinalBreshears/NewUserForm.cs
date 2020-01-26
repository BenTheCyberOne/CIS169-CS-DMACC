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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFinalBreshears
{
    public partial class NewUserForm : Form
    {
        Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
        Regex regex = new Regex(@"^[a-zA-Z ]*$");//for text only


        public NewUserForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)// we will submit the user input into the database after checking all conditions
        {
            // cs is the data source path for the local database
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|StudentInfoDB.mdf; Integrated Security=True; Connect Timeout=30";
            SqlConnection connection = new SqlConnection(cs);// connect to the database
            // here we create the SQL command and assign what the parameters are after input validation
            SqlCommand newUser = new SqlCommand("INSERT into StudentInfo(studentID,fname,lname,password) VALUES (@sID,@fname,@lname,@password)", connection);
            if (fnameTextBox.Text == "" || regex.IsMatch(fnameTextBox.Text) == false || lnameTextBox.Text == "" || regex.IsMatch(lnameTextBox.Text) == false)
            {
                MessageBox.Show("Please enter a valid first and last name (no special characters please!)");
            }
            else if (studentIDTextBox.Text == "" || r.IsMatch(studentIDTextBox.Text) || studentIDTextBox.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Please enter a valid student ID");
            }
            else if (studentIDTextBox.Text.Length < 3)
            {
                MessageBox.Show("Student ID must be 4 or more numbers!");
            }
            else if (passwordTextBox.Text.Length < 5)
            {
                MessageBox.Show("Password must be between 5 and 10 characters!");
            }
            else
            {
                try // we put a try here so that if we enter an already existing student, we will be notified and the program will not crash
                {
                    newUser.Connection.Open();
                    newUser.Parameters.AddWithValue("@sID", studentIDTextBox.Text);
                    newUser.Parameters.AddWithValue("@fname", fnameTextBox.Text);
                    newUser.Parameters.AddWithValue("@lname", lnameTextBox.Text);
                    newUser.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    newUser.ExecuteNonQuery();
                    // create a new student object and set the variables
                    Student s = new Student(Convert.ToInt32(studentIDTextBox.Text), fnameTextBox.Text, lnameTextBox.Text, passwordTextBox.Text);
                    MessageBox.Show("Student created successfully!\nStudent ID: " + s.studentID + "\nPassword: " + s.password);
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)// exit the program
        {
            this.Close();
        }
    }
}
