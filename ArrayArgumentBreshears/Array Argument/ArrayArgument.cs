/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Array Argument
 The user can click a button and view array values, as well as appending said values to the "ArrayArgument.txt" file
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
    public partial class ArrayArgument : Form
    {
        public ArrayArgument()
        {
            InitializeComponent();
        }

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            // Create an int array.
            int[] numbers = { 1, 2, 3 };
           
            // Display the array in the list box.
            outputListBox.Items.Add("The array's original contents:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }

            // Pass the array to the AppendToFile method
            AppendToFile(numbers);
            // Pass the array to the SetToZero method.
            SetToZero(numbers);

            // Display the array in the list box again.
            outputListBox.Items.Add("");
            outputListBox.Items.Add("After calling AppendToFile and SetToZero:");
            foreach (int number in numbers)
            {
                outputListBox.Items.Add(number);
            }
        }
        private void AppendToFile(int[] numberArray)//For every value in the array, append it to a text file 
        {
            try
            {
                StreamWriter outputFile = File.AppendText("ArrayArgument.txt");
                foreach (int number in numberArray)
                {
                    outputFile.WriteLine(number.ToString());
                }
                outputFile.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // The SetToZero method accepts an int array as an
        // argument and sets its elememts to 0.
        private void SetToZero(int[] iArray)
        {
            for (int index = 0; index < iArray.Length; index++)
            {
                iArray[index] = 0;
            }
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
