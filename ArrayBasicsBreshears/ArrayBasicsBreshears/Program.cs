/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Average Test Scores Using Arrays
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
            int[] morganScores = new int[3];
            int[] bowieScores = new int[5];
            int[] ananyaScores = new int[4];
            int morganTotal = 0;
            int bowieTotal = 0;
            int ananyaTotal = 0;
            while (true)
            {
                for (int i = 0; i < morganScores.Length; i++)
                {
                    Console.WriteLine("Please enter Morgan's {0} test score:", (i + 1));
                    try
                    {
                        morganScores[i] = Convert.ToInt32(Console.ReadLine());
                        morganTotal += morganScores[i];
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Morgan's scores...");
                        i = -1;
                        morganTotal = 0;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < bowieScores.Length; i++)
                {
                    Console.WriteLine("Please enter Bowie's {0} test score:", (i + 1));
                    try
                    {
                        bowieScores[i] = Convert.ToInt32(Console.ReadLine());
                        bowieTotal += bowieScores[i];
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Bowie's scores...");
                        i = -1;
                        bowieTotal = 0;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < ananyaScores.Length; i++)
                {
                    Console.WriteLine("Please enter Ananya's {0} test score:", (i + 1));
                    try
                    {
                        ananyaScores[i] = Convert.ToInt32(Console.ReadLine());
                        ananyaTotal += ananyaScores[i];
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
            Console.WriteLine("Morgan's test average is: {0}",(morganTotal / 3));
            Console.WriteLine("Bowie's test average is: {0}", (bowieTotal / 5));
            Console.WriteLine("Ananya's test average is: {0}", (ananyaTotal / 4));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
