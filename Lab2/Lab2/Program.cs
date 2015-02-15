//Mike Zhukovskiy
//IT 215 Spring 2015 Yusuf
//Lab 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user's input
            Console.WriteLine("Enter a sentence:");
            String input = Console.ReadLine();

            //Repeat it to the user
            Console.WriteLine("\nYou entered:");
            Console.WriteLine(input);

            //Split the string
            var words = input.Split();

            var distinctWords = (from word in words
                                 let lowerCaseWord = word.ToLower()
                                 orderby word
                                 select word).Distinct();

            //Print the distinct words
            Console.WriteLine("\nDistinct words: ");
            foreach (var word in distinctWords)
            {
                Console.Write("{0} ", word);
            }
            Console.WriteLine();
        }
    }
}
