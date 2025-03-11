using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class SolverThree : Solver<string>
    {
        public SolverThree()
        {
            A = new List<string>();
        }
        public override void ReadInput()
        {
            Console.WriteLine("Insert {0} string(s):__", N);
            // Assuming the input contains a sequence of non-empty strings
            for (int i = 0; i < N; ++i)
            {
                string x = Console.ReadLine();
                A.Add(x);
            }
        }

        public override void SolveProblemOne()
        {
            // Problem Three Tier One
            Console.WriteLine("Strings containing the letter 'o':");
            for (int i = 0; i < A.Count; ++i)
            {
                if (A[i].Contains('o'))
                {
                    Console.WriteLine(A[i]);
                }
            }   
        }

        public override void SolveProblemTwo()
        {
            // Problem One Tier Three
            Console.WriteLine("Strings that are palindromes:");
            for (int i = 0; i < A.Count; ++i)
            {
                if (IsPalindrome(A[i]))
                {
                    Console.WriteLine(A[i]);
                }
            }
        }

        public override void SolveProblemThree()
        {
            // Problem Two Tier Three
            Console.WriteLine("Strings that are anagrams:");
            List<Hashtable> H = createHashTable();
            for (int i = 0; i < A.Count; ++i)
            {
                if (IsAnagram(i, H))
                {
                    Console.WriteLine(A[i]);
                }
            }
        }

        // Checking if a string is a palindrome using two pointers
        bool IsPalindrome(string S)
        {
            int i = 0;
            int j = S.Length - 1;
            while (i <= j)
            {
                if (S[i] != S[j])
                {
                    return false;
                }
                ++i;
                --j;
            }
            return true;
        }

        // Create A Hash Table containing, for each string, the frequency of every letter that appears in it
        List<Hashtable> createHashTable()
        {
            List<Hashtable> H = new List<Hashtable>();
            for (int i = 0; i < A.Count; ++i)
            {
                H.Add(new Hashtable());
            }
            for (int i = 0; i < A.Count; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    if (H[i].ContainsKey(A[i][j]))
                    {
                        H[i][A[i][j]] = (int) H[i][A[i][j]] + 1;
                    }
                    else
                    {
                        H[i].Add(A[i][j], 1);
                    }
                }
            }
            return H;
        }
        
        // Check if a string is an anagram of some other
        bool IsAnagram(int i, List<Hashtable> H)
        {
            for (int j = 0; j < A.Count; ++j)
            {
                if (i == j) continue;
                bool AreAnagrams = A[i].Length == A[j].Length;
                foreach (DictionaryEntry entry in H[i])
                {
                    char character = (char) entry.Key;
                    int frequency = (int) entry.Value;
                    if (!H[j].ContainsKey(character) || H[j].ContainsKey(character) && (int) H[j][character] != frequency)
                    {
                        AreAnagrams = false;
                    }
                }
                if (AreAnagrams)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
