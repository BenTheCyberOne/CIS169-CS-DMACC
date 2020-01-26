/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Polymorphism
 The user can click a button and create a standard animal, cat, or dog and be displayed information on the child class
 ### This is a class file for the form: Polymorphism ###
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polymorphism
{
    class Animal
    {
        public string _species { get; set; }
        public Animal(string s)//constructor to set the species type
        {
            _species = s;
        }
        public virtual void makeSound()//make a generic animal sound
        {
            MessageBox.Show("Grrrrr");
        }
    }
}
