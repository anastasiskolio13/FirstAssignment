using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierThreeProblemTwo
    {
        public static List<string> SolveT3P2(List<string> listOfStrings)
        {
            List<string> anagrams = new List<string>();
            List<Dictionary<char, int>> DictionaryOfOccurrences = new List<Dictionary<char, int>>();
            for (int i = 0; i < listOfStrings.Count; ++i)
            {
                Dictionary<char, int> x = CountOccurrencesOfLettersOf(listOfStrings[i]);
                DictionaryOfOccurrences.Add(x);
            }
            for (int i = 0; i < listOfStrings.Count; ++i)
            {
                for (int j = 0; j < listOfStrings.Count; ++j)
                {
                    if (i == j)
                        continue;
                    if (AreAnagrams(DictionaryOfOccurrences[i], DictionaryOfOccurrences[j]))
                    {
                        anagrams.Add(listOfStrings[i]);
                        break;
                    }
                }
            }
            return anagrams;
        }

        // For a string S return a Dictionary containing the number of occurrences of each letter in S
        public static Dictionary<char, int> CountOccurrencesOfLettersOf(string S)
        {
            Dictionary<char, int> Occurrences = new Dictionary<char, int>();
            foreach (char character in S)
            {
                if (Occurrences.ContainsKey(character))
                {
                    Occurrences[character] += 1;
                }
                else
                {
                    Occurrences.Add(character, 1);
                }
            }
            return Occurrences;
        }

        // Check if two strings are anagrams by comparing their Dictionaries
        public static bool AreAnagrams(Dictionary<char, int> DictionaryOne, Dictionary<char, int> DictionaryTwo)
        {
            foreach (var entry in DictionaryOne)
                if (!DictionaryTwo.ContainsKey(entry.Key) || DictionaryTwo.ContainsKey(entry.Key) && entry.Value != DictionaryTwo[entry.Key])
                    return false;
            return DictionaryOne.Count == DictionaryTwo.Count;
        }
    }
}
