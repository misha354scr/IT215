using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Lab3
    {
        static Random _random = new Random();

        static void Main(string[] args)
        {
            List<char> letters = new List<char>();

            for (int i = 0; i < 30; i++) {
                letters.Add(GetLetter());
            }

            Console.WriteLine("Generated List: ");
            foreach (char letter in letters) 
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();

            //Sort in ascending order
            Console.WriteLine("\nAscending order:");
            var ascending = from letter in letters
                            orderby letter
                            select letter;
            foreach (char letter in ascending) 
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();

            //Sort in descending order
            Console.WriteLine("\nDescending order:");
            var descending = from letter in letters
                            orderby letter descending
                            select letter;
            foreach (char letter in descending)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nAscending order, no duplicates:");
            foreach (char letter in ascending.Distinct())
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("\n");
        }
    
       // Taken from http://www.dotnetperls.com/random-lowercase-letter
       public static char GetLetter()
        {
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }

    
    }
}
