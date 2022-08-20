using System;
using System.Collections.Generic;

namespace H1_MikkelRæv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tool to find the longest word in a string array
            LongestWordFinder lwf = new LongestWordFinder();

            // Take user input
            Console.WriteLine("Indtast et eller flere ord: ");
            string input = Console.ReadLine();

            // Find the longest word in the input
            List<string> longestWords = lwf.FindLongestWord(input.Split(' '));

            // Write the result
            Console.WriteLine("\nDe(t) længste ord i dit input var:\n");

            for (int i = 0; i < longestWords.Count; i++)
            {
                Console.WriteLine(longestWords[i]);
            }
            Console.ReadKey();
        }
    }
}
