/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Array Argument Algorithm
 The user can click a button to generate an array, then view the minimum and maximum values.
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

namespace Array_Argument
{
    public partial class ArrayArgumentAlgorithm : Form
    {
        public ArrayArgumentAlgorithm()
        {
            InitializeComponent();
        }
        public int[] numbers = new int[15];//array must be declared publicly for requirements of the assignment
        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            Random rnd = new Random();//generate random numbers from 1-99 then add them to each element in the numbers array
            for (int i = 0; i < numbers.Length; i++)
            {
                int randNum = rnd.Next(0, 100);
                numbers[i] = randNum;
            }

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

            private void findMaxButton_Click(object sender, EventArgs e)//run the findMaxValue function
            {
            if (numbers.Sum() != 0)//if the sum of all elements in the array = 0, don't run the function
            {
                findMaxValue(numbers);
            }
            else
            {
                MessageBox.Show("There is no values in the array!");
            }
        }


            private void findMinButton_Click(object sender, EventArgs e)//run the findMinValue function
            {
            if (numbers.Sum() != 0)//if the sum of all elements in the array = 0, don't run the function
            {
                findMinValue(numbers);
            }
            else
            {
                MessageBox.Show("There is no values in the array!");
            }
        }
            private void findMaxValue(int[] numbers)//grab the max value in the array and display it
        {
            int m = numbers.Max();
            MessageBox.Show("The array's max value is: " + m);
        }
            private void findMinValue(int[] numbers)//grab the min value in the array and display it
        {
            int m = numbers.Min();
            MessageBox.Show("The array's min value is: " + m);
        }
        }
    }
