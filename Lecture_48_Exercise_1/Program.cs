using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_48_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisibleByThreeCounter = 0;
            for (var iCounter = 1; iCounter < 100; iCounter++)
            {
                if (iCounter%3 == 0)
                {
                    divisibleByThreeCounter++;
                }
            }

            Console.WriteLine("Numbers between 1 - 100 that are divisible by 3 with no remainder = " + divisibleByThreeCounter);
            ShowExit();
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
