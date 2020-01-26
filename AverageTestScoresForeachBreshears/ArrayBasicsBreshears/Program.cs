/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Average Test Scores Using Foreach
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
            int SIZE = 4;
            int[] morganScores = new int[SIZE];
            int[] bowieScores = new int[SIZE];
            int[] ananyaScores = new int[SIZE];
            while (true)
            {
                for (int i = 0; i < morganScores.Length; i++)
                {
                    Console.WriteLine("Please enter Morgan's {0} test score:", (i + 1));
                    try
                    {
                        morganScores[i] = Convert.ToInt32(Console.ReadLine());
                        if (morganScores[i] < 1 || morganScores[i] > 100)
                        {//test if score is below 1 or above 100, if it is then reset
                            Console.WriteLine("Error: Please enter a valid test score (integers between 1 and 100 only)\nPress any key to reset Morgan's scores...");
                            i = -1;
                            Console.ReadKey();
                        }

                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Morgan's scores...");
                        i = -1;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < bowieScores.Length; i++)
                {
                    Console.WriteLine("Please enter Bowie's {0} test score:", (i + 1));
                    try
                    {
                        bowieScores[i] = Convert.ToInt32(Console.ReadLine());
                        if (bowieScores[i] < 1 || bowieScores[i] > 100)
                        {//test if score is below 1 or above 100, if it is then reset
                            Console.WriteLine("Error: Please enter a valid test score (integers between 1 and 100 only)\nPress any key to reset Bowie's scores...");
                            i = -1;
                            Console.ReadKey();
                        }
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Bowie's scores...");
                        i = -1;
                        Console.ReadKey();
                    }
                }
                for (int i = 0; i < ananyaScores.Length; i++)
                {
                    Console.WriteLine("Please enter Ananya's {0} test score:", (i + 1));
                    try
                    {
                        ananyaScores[i] = Convert.ToInt32(Console.ReadLine());
                        if (ananyaScores[i] < 1 || ananyaScores[i] > 100)
                        {//test if score is below 1 or above 100, if it is then reset
                            Console.WriteLine("Error: Please enter a valid test score (integers between 1 and 100 only)\nPress any key to reset Ananya's scores...");
                            i = -1;
                            Console.ReadKey();
                        }
                    }
                    catch//If the user inputs something other than an int, we reset the for loop and reset the total summation variable
                    {
                        Console.WriteLine("Error: Please enter a valid test score (integers only)\nPress any key to reset Ananya's scores...");
                        i = -1;
                        Console.ReadKey();
                    }
                }
                break;//break the while-true loop
            }
            DisplayAverages(morganScores, bowieScores, ananyaScores, SIZE);
        }
        static void DisplayAverages(int[] morganScores, int[] bowieScores, int[] ananyaScores, int SIZE)
        {
            double avgMorgan = 0;
            double avgBowie = 0;
            double avgAnanya = 0;
            foreach (int score in morganScores){
                avgMorgan += score;
            }
            foreach (int score in bowieScores)
            {
                avgBowie += score;
            }
            foreach (int score in ananyaScores)
            {
                avgAnanya += score;
            }
            Console.WriteLine("Morgan's test average is: {0}",(avgMorgan / SIZE));
            Console.WriteLine("Bowie's test average is: {0}", (avgBowie / SIZE));
            Console.WriteLine("Ananya's test average is: {0}", (avgAnanya / SIZE));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
