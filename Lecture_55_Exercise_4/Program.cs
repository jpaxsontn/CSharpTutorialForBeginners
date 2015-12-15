using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_55_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter a number or type \"Quit\" to exit");
            var input = Console.ReadLine();
            while (input.ToLower() != "quit")
            {
                int parsedInput;
                if (!Int32.TryParse(input, out parsedInput))
                {
                    Console.WriteLine("Invalid input, try again");
                }
                else
                {
                    numbers.Add(parsedInput);
                }

                Console.WriteLine("Enter a number or type \"Quit\" to exit");
                input = Console.ReadLine();
            }

            var uniqueNumbers = new List<int>();
            foreach (var iNumber in numbers)
            {
                if (!uniqueNumbers.Contains(iNumber))
                {
                    uniqueNumbers.Add(iNumber);
                }
            }

            Console.WriteLine("You entered the following unique numbers");
            foreach (var iNumber in uniqueNumbers)
            {
                Console.WriteLine(iNumber);
            }

            Console.ReadKey();
        }
    }
}
