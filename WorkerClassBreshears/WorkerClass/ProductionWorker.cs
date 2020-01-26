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
    class ProductionWorker : Employee
    {
        private string s;
        public int _shiftNum { get; set; }
        public double _payRate { get; set; }
        public ProductionWorker(string name, int num, int shiftNum, double payRate) : base(name, num)//constructor with base of Employee
        {
            _shiftNum = shiftNum;
            _payRate = payRate;
        }
        public override string shiftType//return what type of shift it is according to the number passed from the main form
        {
            get
            {
                if(_shiftNum == 1)
                {
                    s = "Day Shift";
                    return s;
                }
                else
                {
                    s = "Night Shift";
                    return s;
                }
            }
        }
    }
}
