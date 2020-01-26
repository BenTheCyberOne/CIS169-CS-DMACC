/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Average Test Scores For Loop
 The user can input up to four integers and get the average
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

namespace AverageTestScoresForBreshears
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Please enter the {0} value", i);
                try
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                }
                catch//If user inputs anything other than integer, restart the for loop
                {
                    Console.WriteLine("Please enter a valid integer next time!\nPress any key to restart...");
                    //We have to reset the sum and i variable incase the user breaks the program halfway through the calculation
                    sum = 0;
                    i = 0; //we are off by one, so i must be set one below the set value in the for container
                    Console.ReadKey();
                }
            }
            double average = sum / 4;
            Console.WriteLine("The average is: {0:0.00}", average); //format the average to two decimal places
            Console.WriteLine("Enter any key to quit...");
            Console.ReadKey();
        }
    }
}
