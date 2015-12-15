using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_55_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>();

            Console.WriteLine("Enter the name of a friend - Press enter on a blank line to quit");
            string input = null;
            input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                friends.Add(input);
                input = Console.ReadLine();
            } 

            if(friends.Count == 1)
            {
                Console.WriteLine(friends[0] + " likes your post.");
            }
            else if(friends.Count == 2)
            {
                Console.WriteLine(friends[0] + " and " + friends[1] + " like your post");
            } else if(friends.Count > 2)
            {
                Console.WriteLine(friends[0] + ", " + friends[1] + " and " + (friends.Count - 2) + " others like your post.");
            }

            Console.ReadKey();
        }
    }
}
