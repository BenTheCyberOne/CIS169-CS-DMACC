/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Average Test Scores While Loop
 The user can input up to three integers and get the average
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

namespace AverageTestScoresWhileBreshears
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            double sum = 0;
            int total = 4;
            while (count < total)//Will run the following block exactly 3 times
            {
                Console.WriteLine("Please enter the {0} value", count);
                try
                {
                    sum += Convert.ToDouble(Console.ReadLine());
                    count++;
                }
                catch//If user inputs anything other than integer, restart the while loop
                {
                    Console.WriteLine("Please enter a valid integer next time!\nPress any key to restart...");
                    //We have to reset the counting variables in a while loop incase the user breaks the program halfway through the calculations
                    sum = 0;
                    count = 1;
                    Console.ReadKey();
                }
            }
            double average = sum / 3;
            Console.WriteLine("The average is: {0:0.00}", average); //format the average to two decimal places
            Console.WriteLine("Enter any key to quit...");
            Console.ReadKey();
        }
    }
}
