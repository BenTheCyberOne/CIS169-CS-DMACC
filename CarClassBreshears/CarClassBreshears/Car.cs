/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Car Class Challenge
 The user can click a button to accelerate or decellerate a car object, as well as set the make and year
 ### This is a class file - not the main program! ###
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

namespace CarClassBreshears
{
    class Car
    {
        private int _year;
        private string _make;
        private int _speed;
        public Car()//default constructor for class Car
        {
            _year = 2013;
            _make = "Corolla";
            _speed = 0;
        }
        public Car(int year, string make)//constructor used for program
        {
            _year = year;
            _make = make;
            _speed = 0;
        }

        public int Year//get and set for year value
        {
            get { return _year; }
            set { _year = value; }
        }
        public string Make//get and set for make value
        {
            get { return _make; }
            set { _make = value; }
        }
        public int Speed//get and set for speed value
        {
            get { return _speed; }
            set { _speed = value; }
        }
        
        public void Accelerate()//since this program does not lookup max speed values, we will allow speed to rise indefinitely (Possible TO-DO)
        {
            _speed += 5;
        }
        public Boolean Break()//set as boolean type so that we can handle what to do below 0 on the front-end customly
        {
            if ((_speed - 5) >= 0)
            {
                _speed -= 5;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
