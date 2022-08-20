using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_MikkelRæv
{
    internal class LongestWordFinder
    {
        // Remove all punctuation from the words, to ensure that the results aren't being padded by punctuation.
        public string StripPunctuation(string s)
        {
            StringBuilder sb = new StringBuilder();

            // Check each char in the string
            foreach (char c in s)
            {
                // Append all the chars that aren't punctuation to the return value
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            
            return sb.ToString();
        }

        public List<string> FindLongestWord(string[] s)
        {
            // The length of the currently longest word(s).
            int longestWordLength = 0;
            // The currently longest word(s).
            List<string> longestWords = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                // Remove punctuation from each word, and avoid duplication by turning all letters lowercase.
                s[i] = StripPunctuation(s[i].ToLower());

                // If the current word is the longest we've come across yet, save a copy of it, and update the length required to beat it.
                if (s[i].Length > longestWordLength)
                {
                    longestWordLength = s[i].Length;
                    longestWords.Clear(); // Clear the list, remove all existing entries. Only words of the current highest length can be in the list.
                    longestWords.Add(s[i]);
                }
                // If the word is equally as long as the currently longest word, add it at the end to return all words of the longest length.
                else if (s[i].Length == longestWordLength)
                {
                    // Avoid duplicate entries by only adding words that don't already exist.
                    if (!longestWords.Contains(s[i]))
                    {
                        longestWords.Add(s[i]);
                    }
                }
            }

            // Return a string containing all the longest words from the array.
            return longestWords;
        }
    }
}
