using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_48_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var number = Console.ReadLine();
            var factorial = Factorial(Int32.Parse(number));
            Console.WriteLine(number + "! = " + factorial);
            ShowExit();
        }

        static int Factorial(int number)
        {
            int factorial = 1;
            for (var iCounter = number; iCounter >= 1; iCounter--)
            {
                factorial = factorial*iCounter;
            }

            return factorial;
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
