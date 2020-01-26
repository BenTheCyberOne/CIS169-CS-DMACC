/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Array Argument Sorting
 The user can click a button and view array values, as well as sorting the values in descending order
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
using System.Windows.Forms;
using System.IO;
namespace Array_Argument
{
    public partial class ArrayArgumentSort : Form
    {
        public ArrayArgumentSort()
        {
            InitializeComponent();
        }
       public int[] numbers = { 1, 2, 3 };//to run the program this way, this array must be public

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
                       
            // Display the array in the list box.
            outputListBox.Items.Add("The array's contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void sortButton_Click(object sender, EventArgs e)//sort the hardcoded public array
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);//sort in descending order
            String numList = "";
            foreach (int number in numbers)//add each sorted element to a string
            {
                numList += number;
            }
            MessageBox.Show("Sorted in descending order:\n" + numList);//display the sorted array as a string
        }
    }
}
