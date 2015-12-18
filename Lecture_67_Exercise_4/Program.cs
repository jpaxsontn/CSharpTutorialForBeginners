using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words seperated by a space");
            var input = Console.ReadLine();
            var words = input.ToLower().Split(' ').ToList();

            Console.WriteLine("Pascal Variable = " + CreatePascalVariable(words));
            Console.ReadKey();
        }

        private static StringBuilder CreatePascalVariable(List<string> words)
        {
            StringBuilder pascalVariable = new StringBuilder();
            foreach(var iWord in words)
            {
                pascalVariable.Append(iWord.Substring(0, 1).ToUpper());
                pascalVariable.Append(iWord.Substring(1));
                
            }

            return pascalVariable;
        }
    }
}
