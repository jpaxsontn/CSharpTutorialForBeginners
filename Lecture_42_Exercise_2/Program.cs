using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter #1");
            var numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter #2");
            var numberTwo = Int32.Parse(Console.ReadLine());

            var greaterNumber = GreaterNumber(numberOne, numberTwo);
            if (greaterNumber == 0)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Greate number is " + greaterNumber);
            }

            ShowExit();
        }

        static int GreaterNumber(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }
            else if (numberTwo > numberOne)
            {
                return numberTwo;
            }

            return 0;
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
