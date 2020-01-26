/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 String Variable Demo
 This program takes input of a first name and a last name, then concatenates the strings for output a single string to output with names beginning with uppercase letters.
 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.

=========================================================== **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringVariableDemoBreshears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string fullName;
            fullName = (char.ToUpper(FirstNameBox.Text[0]) + FirstNameBox.Text.Substring(1)) + " " + (char.ToUpper(LastNameBox.Text[0]) + LastNameBox.Text.Substring(1));
            FullNameAnswer.Text = fullName;
        }
    }
}
