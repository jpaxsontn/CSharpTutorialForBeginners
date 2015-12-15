using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_55_Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            char[] reversedName = new char[name.Length];
            for(var iCounter = name.Length - 1; iCounter >= 0; iCounter--)
            {
                reversedName[(name.Length - 1) - iCounter] = name[iCounter];
            }

            Console.WriteLine(reversedName);
            Console.ReadKey();
        }
    }
}
