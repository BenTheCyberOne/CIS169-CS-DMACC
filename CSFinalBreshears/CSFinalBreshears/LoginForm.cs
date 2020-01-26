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
    public partial class LoginForm : Form
    {
        Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
        // cs is the data source path string to the local database
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|StudentInfoDB.mdf; Integrated Security=True; Connect Timeout=30";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)//exit the program
        {
            this.Close();
        }

        private void newStudentButton_Click(object sender, EventArgs e)// opens the form to create a new user
        {
            NewUserForm x = new NewUserForm();
            x.ShowDialog();
        }
        public void login()
        {
            if (studentIDTextBox.Text == "" || r.IsMatch(studentIDTextBox.Text) || studentIDTextBox.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Please enter a valid student ID");
                studentIDTextBox.Text = "";
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("Please enter a password");
            }
            else
            {
                SqlConnection connection = new SqlConnection(cs);// connect to the database
                // here we create the SQL command and assign what the parameters are
                SqlCommand login = new SqlCommand("SELECT studentID,password,fname as a,admin as isAdmin FROM StudentInfo WHERE studentID = @sID AND password = @password", connection);
                login.Parameters.AddWithValue("@sID", studentIDTextBox.Text);
                login.Parameters.AddWithValue("@password", passwordTextBox.Text);
                login.Connection.Open();
                SqlDataReader reader = login.ExecuteReader(CommandBehavior.CloseConnection);
                // here we read to check if the record with the associating studentID and password exist. If they do, we will 'login'
                if (reader.Read() == true)
                {
                    UserExists f = new UserExists();
                    string fname = reader["a"].ToString();
                    int isAdmin = Convert.ToInt32(reader["isAdmin"]);// is this user an admin? If yes, we will open the Admin console upon login
                    int studentID = Convert.ToInt32(studentIDTextBox.Text);
                    f.studentName = fname.Trim();
                    f.studentID = studentID;
                    //this.Hide();
                    if (isAdmin == 1)
                    {
                        AdminPanel ap = new AdminPanel();
                        ap.ShowDialog();
                    }
                    else
                    {
                        f.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Login Failed. Please check your studentID and password and try again.");
                    studentIDTextBox.Clear();
                    passwordTextBox.Clear();
                }
                if (connection.State == ConnectionState.Open)//close the connection when we don't need it anymore
                {
                    connection.Dispose();
                }

            }
        }
        public void loginButton_Click(object sender, EventArgs e)// checks with the database then logs the user in
        {
            login();
        }
    }
}
