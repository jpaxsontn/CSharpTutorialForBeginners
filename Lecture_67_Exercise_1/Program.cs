using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers seperated by a hypen");
            var input = Console.ReadLine();

            var parsedInput = input.Split('-').ToList();
            var numbers = GetNumbers(parsedInput);

            if (AreNumbersConsecutive(numbers))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
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

        private static bool AreNumbersConsecutive(List<int> numbers)
        {
            for (var iCounter = 1; iCounter <= numbers.Count - 1; iCounter++)
            {
                var currentNumber = numbers[iCounter - 1];
                var nextNumber = numbers[iCounter];
                if ((currentNumber + 1 != nextNumber) && (currentNumber - 1 != nextNumber))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
