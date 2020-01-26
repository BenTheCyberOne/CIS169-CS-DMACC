/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Arithmetic Operations
 The user can demonstrate each of the arithmetic operations by clicking a button
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

namespace ArithmeticOperationsBreshears
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowOperationsButton_Click(object sender, EventArgs e)
        {
            int addAns = 5 + 4;
            int subAns = 5 - 4;
            int multAns = 5 * 4;
            int divAns = 20 / 5;
            int modAns = 5 % 3;
            int incAns = 4;
            int incAns2 = 4;
            AdditionBox.Text = "5 + 4 = " + addAns.ToString();
            SubtractionBox.Text = "5 - 4 = " + subAns.ToString();
            MultiplyBox.Text = "5 * 4 = " + multAns.ToString();
            DivisionBox.Text = "20 / 5 = " + divAns.ToString();
            ModulusBox.Text = "5 % 3 = " + modAns.ToString();
            PositiveIBox.Text = "4++ = " + (++incAns);
            NegativeIBox.Text = "4-- = " + (--incAns2);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // I had accidentally linked references to the below objects, please ignore!
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
