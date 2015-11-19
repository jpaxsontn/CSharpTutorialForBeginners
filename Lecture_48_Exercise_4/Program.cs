using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_48_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(1, 11);
            Console.WriteLine("Guess the random number between 1 and 10");
            for (var iGuess = 0; iGuess <= 3; iGuess++)
            {
                var guess = Console.ReadLine();
                if (guess == randomNumber.ToString())
                {
                    Console.WriteLine("You won");
                    ShowExit();
                    return;
                }
            }

            Console.WriteLine("You lost");
            Console.WriteLine("The correct number was " + randomNumber);
            ShowExit();
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
