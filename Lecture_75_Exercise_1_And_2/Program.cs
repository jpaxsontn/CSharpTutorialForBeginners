using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture_75_Exercise_1_And_2
{
    enum Operation { NumberOfWords = 1, NumberOfRepeatedWords };
    class Program
    {
        static void Main(string[] args)
        {
            //Validate input
            if(IsValidFile(args) == false)
            {
                Console.WriteLine("Invalid command line input");
                Console.ReadKey();
                return;
            }

            var operation = GetOperation();
            switch (operation)
            {
                case Operation.NumberOfWords:
                    OperationOne(args[0]);
                    break;
                case Operation.NumberOfRepeatedWords:
                    OperationTwo(args[0]);
                    break;
            }

            Console.ReadKey();

        }

        public static void OperationOne(string filePath)
        {
            Console.WriteLine("The number of words in the file " + filePath);
            var input = File.ReadAllText(filePath);
            var numberOfWords = GetWords(input).Count();
            Console.WriteLine(numberOfWords);
        }

        public static void OperationTwo(string filePath)
        {
            Console.WriteLine("The three most repeated words in the file " + filePath);
            var input = File.ReadAllText(filePath);
            var words = GetWords(input);
            var uniqueWords = GetUniqueWords(words);
            var sortedWords = SortWordsByOccurrence(words, uniqueWords);
            var topThreeCounter = 0;
            foreach(var iWord in sortedWords)
            {
                if(topThreeCounter < 3)
                {
                    int wordCount = GetNumberOfOccurrences(iWord, words);
                    Console.Write(iWord + "\t\t repeated " + wordCount + " time");
                    if(wordCount > 1)
                    {
                        Console.Write("s");
                    }
                    Console.WriteLine();
                    topThreeCounter++;
                }
            }
        }

        public static List<string> SortWordsByOccurrence(List<string> words, List<string> uniqueWords)
        {
            List<string> sortedWords = new List<string>();
            foreach(var iWord in uniqueWords)
            {
                sortedWords.Add(GetMostRepeatedWordWithExclusions(iWord, words, sortedWords));
            }

            return sortedWords;
        }

        public static string GetMostRepeatedWordWithExclusions(string word, List<string> words, List<string> exclusions)
        {
            int mostFrequentWordCount = 0;
            string mostFrequentWord = null;
            foreach(var iWord in words)
            {
                if (exclusions.Contains(iWord) == false)
                {
                    var wordCount = GetNumberOfOccurrences(iWord, words);
                    if(wordCount > mostFrequentWordCount)
                    {
                        mostFrequentWordCount = wordCount;
                        mostFrequentWord = iWord;
                    }
                }
            }

            return mostFrequentWord;
        }

        
        public static List<string> GetUniqueWords(List<string> words)
        {
            List<string> uniqueWords = new List<string>();
            foreach(var iWord in words)
            {
                if (!uniqueWords.Contains(iWord))
                {
                    uniqueWords.Add(iWord);
                }
            }

            return uniqueWords;
        }

        public static bool IsValidFile(string[] args)
        {
            if(args.Count() == 1 && File.Exists(args[0]))
            {
                return true;
            }

            return false;
        }

        public static Operation GetOperation()
        {
            int numberInput = 0;
            while(numberInput != 1 && numberInput != 2)
            {
                Console.WriteLine("Which operation would you like to perform?");
                Console.WriteLine("1: Read number of words in file");
                Console.WriteLine("2: Read number of three most repeated words");
                Int32.TryParse(Console.ReadLine(), out numberInput);
            }

            Operation operation = (Operation)numberInput;
            return operation;
        }

        public static List<string> GetWords(string input)
        {
            //Using ToLower so all comparisons will be made against lowercase.
            char[] delimiters = new[] { ',', ';', ' ', '\t', '\r', '\n', '.', '?', '!' };
            var words = input.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return words.ToList();
        }

        public static int GetNumberOfOccurrences(string word, List<string> words)
        {
            int count = 0;
            foreach(var iWord in words)
            {
                if(iWord == word)
                {
                    count++;
                }
            }

            return count;
        }

        
    }
}
