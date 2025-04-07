using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierThreeProblemOne
    {
        public static List<string> SolveT3P1(List<string> listOfStrings)
        {
            List<string> palindromes = new List<string>();
            for (int i = 0; i < listOfStrings.Count; ++i)
            {
                if (IsPalindrome(listOfStrings[i]))
                {
                    palindromes.Add(listOfStrings[i]);
                }
            }
            return palindromes;
        }

        // Checking if a string is a palindrome using two pointers
        public static bool IsPalindrome(string S)
        {
            int i = 0;
            int j = S.Length - 1;
            while (i <= j)
            {
                if (S[i] != S[j])
                    return false;
                ++i;
                --j;
            }
            return true;
        }
    }
}
