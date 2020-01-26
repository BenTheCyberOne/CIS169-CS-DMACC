/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Production Worker Class
 The user can input employee information and view it's created object information
 ### This is a class for the form WorkerForm ###
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

namespace WorkerClass
{
    abstract class Employee
    {
        public string empName { get; set; }
        public int empNum { get; set; }
        public Employee()//default constructor
        {
            empName = "";
            empNum = 0;
        }
        public Employee(string name, int num)//employee constructor
        {
            empName = name;
            empNum = num;
        }
        public abstract string shiftType//abstract method to get the shift type
        {
            get;
        }
    }
}
