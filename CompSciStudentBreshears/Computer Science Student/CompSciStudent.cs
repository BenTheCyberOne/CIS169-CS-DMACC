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
    class CompSciStudent : Student
    {
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;
        public string _academicTrack { get; set; }
        public CompSciStudent(string name, string id, string track) : base(name, id)//constructor with base of student
        {
            _academicTrack = track;
        }
        public override double RequiredHours//override the student constructor and return required hour field
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }
    }
}
