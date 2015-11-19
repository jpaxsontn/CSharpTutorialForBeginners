using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_48_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int sum = 0;

            do
            {
                sum += Int32.Parse(input);
                Console.WriteLine("Enter a number or \"ok\" to exit");
                input = Console.ReadLine();
            } while (input != "ok");

            Console.WriteLine("Sum of all numbers = " + sum);
            ShowExit();
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
