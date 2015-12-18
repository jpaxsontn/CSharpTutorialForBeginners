using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers seperated by a hypen");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            var parsedInput = input.Split('-').ToList();
            var numbers = GetNumbers(parsedInput);
            if (AreDuplicates(numbers))
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                Console.WriteLine("No Duplicates");
            }

            Console.ReadKey();
        }

        private static List<int> GetNumbers(List<string> inputList)
        {
            List<int> numbers = new List<int>();
            foreach (var iNumber in inputList)
            {
                numbers.Add(Int32.Parse(iNumber));
            }

            return numbers;
        }

        private static bool AreDuplicates(List<int> numbers)
        {
            for (var iCounter = 0; iCounter <= numbers.Count - 1; iCounter++)
            {
                for (var jCounter = iCounter + 1; jCounter <= numbers.Count - 1; jCounter++)
                {
                    if (numbers[iCounter] == numbers[jCounter])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
