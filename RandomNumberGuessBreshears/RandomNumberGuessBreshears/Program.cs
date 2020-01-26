/** =========================================================

 Ben Breshears
 Windows 10
 Microsoft Visual Studio 2017
 CIS 169 C# 
 Random Number Guessing Game
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

namespace RandomNumberGuessBreshears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Welcome to the Random Number Guessing Game! ###");
            Random rnd = new Random();
            int count = 0;
            int randomNum = rnd.Next(0, 100);
            while (true)// While the program runs, ask for a number from the user and parse it as an int (if it can't, tell the user)
            {
                Console.WriteLine("So human, what's my number?");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    if (userInput > randomNum)//if user's guess is too big
                    {
                        Console.WriteLine("Hmmm... Too big!");
                        count++;
                    }
                    else if (userInput < randomNum)//if user's guess is too small
                    {
                        Console.WriteLine("Hmmm... Too small!");
                        count++;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine("Congratulations human! You guessed correctly!\nYou're number of guesses was: {0}",count);//display the total number of guesses
                        randomNum = rnd.Next(0, 100);
                        count = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }

        }
    }
}
