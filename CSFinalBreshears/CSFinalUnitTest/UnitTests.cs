//note - testing methods cannot connect to local test DB because the SQL classes I need are not viable within a Test environment class
using System;
using CSFinalBreshears;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace CSFinalUnitTest
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void LoginForm_ValidateStudentID()
        {
            Regex r = new Regex(@"[~`!@#$%^&*()+=|\\{}':;.,<>/?[\]""_-]");//regex to validate input
            int sID = 1337;
            if (sID < 1000 || r.IsMatch(sID.ToString()) || sID > 999999999)
            {
                throw new System.ArgumentException("sID must be between 4 and 10 characters and must be an int!");
            }

        }
        [TestMethod]
        public void LoginForm_ValidatePassword()
        {
            // no regex, passwords are allowed to contain special characters
            string pass = "what@you?";
            if (pass.Length < 4 || pass.Length > 10 || pass == "")
            {
                throw new System.ArgumentException("Password must be between 4 and 10 characters!");
            }
        }
        [TestMethod]
        public void FormWideFucntion_GenerateStudent()
        {
            Student s = new Student();
            //will be set from DB later
            s.fname = "Ben";
            s.lname = "Breshears";
            s.studentID = 1337;
            s.password = "werewolf";
            try
            {
                s.DisplayInfo();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        internal class Student
        {
            public string fname { get; set; }
            public string lname { get; set; }
            public int studentID { get; set; }
            public string password { get; set; }
            public Student()
            {
            }
            public Student(string fname, string lname, int sID, string pass)
            {
                this.fname = fname;
                this.lname = lname;
                this.studentID = sID;
                this.password = pass;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Student created with:\n" + fname + "/n" + lname + "\n" + studentID + "\n" + password);
            }
        }
    }
}
