using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_48_Exercise_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by comma's");
            var numbers = Console.ReadLine();
            var numberStringArray = numbers.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            var largestNumber = FindLargestNumber(numberStringArray);
            Console.WriteLine("The largest number is " + largestNumber);
            ShowExit();
        }

        public static int FindLargestNumber(string[] numberStringArray)
        {
            int largestNumber = 0;
            for (var iCounter = 0; iCounter <= numberStringArray.Count() - 1; iCounter++)
            {
                int validNumber = 0;
                if (Int32.TryParse(numberStringArray[iCounter], out validNumber))
                {
                    if (validNumber > largestNumber)
                    {
                        largestNumber = validNumber;
                    }
                }
            }

            return largestNumber;
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
