using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_55_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
            var numbers = new List<int>();
            var input = Console.ReadLine();

            while (numbers.Count < 5)
            {
                var nonParsedInputArray = input.Split(',');
                foreach (var iInput in nonParsedInputArray)
                {
                    int validNumber;
                    if (Int32.TryParse(iInput, out validNumber))
                    {
                        numbers.Add(validNumber);
                    }
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List, please try again");
                    input = Console.ReadLine();
                    numbers.Clear();
                }
            }

            Console.WriteLine("The three smallest numbers you entered are");
            numbers.Sort();
            for (var iCounter = 0; iCounter < 3; iCounter++)
            {
                Console.WriteLine(numbers[iCounter]);
            }

            Console.ReadKey();
        }
    }
}
