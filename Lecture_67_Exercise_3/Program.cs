using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a time value in the 24-hour time format (e.g. 19:00)");
            var timeInput = Console.ReadLine();
            var parsedInput = timeInput.Split(':').ToList();
            var numbers = GetNumbers(parsedInput);
            if (parsedInput.Count == 2 && IsValidHour(numbers[0]) && IsValidMinute(numbers[1]))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

            Console.ReadKey();
        }

        private static List<int> GetNumbers(List<string> inputList)
        {
            List<int> numbers = new List<int>();
            foreach (var iNumber in inputList)
            {
                int number;
                if (Int32.TryParse(iNumber, out number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static bool IsValidHour(int hour)
        {
            if (hour >= 24 || hour < 0)
            {
                return false;
            }

            return true;
        }

        private static bool IsValidMinute(int minute)
        {
            if (minute >= 60 || minute < 0)
            {
                return false;
            }

            return true;
        }
    }
}
