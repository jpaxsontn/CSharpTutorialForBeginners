using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_67_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word");
            var word = Console.ReadLine();
            Console.WriteLine("Number of vowels = " + CountNumberOfVowels(word));

            Console.ReadKey();
        }

        static int CountNumberOfVowels(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelCounter = 0;
            for(var iCharacterIndex = 0; iCharacterIndex <= word.Length - 1; iCharacterIndex++)
            {
                foreach(var iVowel in vowels)
                {
                    if(word[iCharacterIndex].ToString().ToLower() == iVowel.ToString())
                    {
                        vowelCounter++;
                        break;
                    }
                }
            }

            return vowelCounter;
        }
    }
}
