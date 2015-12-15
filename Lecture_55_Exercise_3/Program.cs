using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_55_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 unique numbers");
            var numbers = new List<int>();
            int inputNumber = Int32.Parse(Console.ReadLine());
            while(numbers.Count < 5)
            {
                if (numbers.Contains(inputNumber))
                {
                    Console.WriteLine("Number has already been entered. Try again");
                }
                else
                {
                    numbers.Add(inputNumber);
                }
                inputNumber = Int32.Parse(Console.ReadLine());
            }

            numbers.Sort();
            Console.WriteLine("Sorted numbers");
            foreach(var iNumber in numbers)
            {
                Console.WriteLine(iNumber);
            }
            Console.ReadKey();
        }
    }
}
