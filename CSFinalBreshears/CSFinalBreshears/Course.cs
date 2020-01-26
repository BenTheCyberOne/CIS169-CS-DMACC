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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFinalBreshears
{
    class Course
    {
        public string name { get; set; }
        public Course()// default constructor
        {

        }
        public Course(string name)// constructor for new course
        {
            this.name = name;
        }
    }
}
