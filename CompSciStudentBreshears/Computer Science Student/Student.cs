/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Computer Science Student Form
 The user can input a CS Student's details and view the required hours
 ### This is a class file for the form CSStudent ###
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
namespace Computer_Science_Student
{
    abstract class Student
    {
        public string _name { get; set; }
        public string _id { get; set; }
        public Student(string name, string id)//constructor for student 
        {
            _name = name;
            _id = id;

        }
        public abstract double RequiredHours//abstract constructor for required hours
        {
            get;
        }
    }
}
