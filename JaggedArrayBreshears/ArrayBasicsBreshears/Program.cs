/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Average Test Scores Using Jagged Arrays
 The user can input the student's test scores and obtain the average of all 3 students
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

namespace ArrayBasicsBreshears
{
    class Program
    {
        static void Main(string[] args)//constantly loop for test scores to the corresponding students (stored in arrays)
        {
            int[][] testScores = new int[3][];//declare the jagged array "testScores" and the row lengths
            testScores[0] = new int[3];
            testScores[1] = new int[5];
            testScores[2] = new int[4];
            int morganTotal = 0;
            int bowieTotal = 0;
            int ananyaTotal = 0;
            while (true)
            {
                for (int i = 0; i < testScores[0].Length; i++)
                {
                    Console.WriteLine("Please enter Morgan's {0} test score:", (i + 1));
                    try
                    {
                        testScores[0][i] = Convert.ToInt32(Console.ReadLine());
                        morganTotal += testScores[0][i];
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Morgan's scores...");
                        i = -1;
                        morganTotal = 0;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < testScores[1].Length; i++)
                {
                    Console.WriteLine("Please enter Bowie's {0} test score:", (i + 1));
                    try
                    {
                        testScores[1][i] = Convert.ToInt32(Console.ReadLine());
                        bowieTotal += testScores[1][i];
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Bowie's scores...");
                        i = -1;
                        bowieTotal = 0;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < testScores[2].Length; i++)
                {
                    Console.WriteLine("Please enter Ananya's {0} test score:", (i + 1));
                    try
                    {
                        testScores[2][i] = Convert.ToInt32(Console.ReadLine());
                        ananyaTotal += testScores[2][i];
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Ananya's scores...");
                        i = -1;
                        ananyaTotal = 0;
                        Console.ReadKey();
                    }
                }
                break;//break the while-true loop
            }
            DisplayAverages(ref morganTotal, ref bowieTotal, ref ananyaTotal);//run the static method with references to the summations as parameters
        }
        static void DisplayAverages(ref int morganTotal, ref int bowieTotal, ref int ananyaTotal)//Calculate and output the averages
        {
            double totalMorg = Convert.ToDouble(morganTotal) / 3;
            double totalBow = Convert.ToDouble(bowieTotal) / 5;
            double totalAnan = Convert.ToDouble(ananyaTotal) / 4;
            Console.WriteLine("Morgan's test average is: {0:0.00}",totalMorg);
            Console.WriteLine("Bowie's test average is: {0:0.00}", totalBow);
            Console.WriteLine("Ananya's test average is: {0:0.00}", totalAnan);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
