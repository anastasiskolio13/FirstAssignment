
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class SolverOne : Solver<char>
    {
        public SolverOne()
        {
            A = new List<char>();
        }
        public override void ReadInput()
        {
            Console.WriteLine("Insert a string of size {0}:__", N);
            // Assuming that the input is a non-empty string of lowercase letters
            for (int i = 0; i < N; ++i)
            {
                char x = (char) Console.Read();
                A.Add(x);
                Console.ReadLine();
            }
        }

        public override void SolveProblemOne()
        {
            // Problem One Tier One
            int occurrences = 0;
            for (int i = 0; i < A.Count; ++i)
            {
                if (A[i] == 'f')
                {
                    ++occurrences;
                }
            }
            Console.WriteLine("The letter 'f' occurs {0} times in the string.", occurrences);
        }

        public override void SolveProblemTwo() 
        {
            // Problem Two Tier One
            int numberOfWords = 1;
            for (int i = 0; i < A.Count; ++i)
            {
                if (A[i] == ' ')
                {
                    ++numberOfWords;
                }
            }
            Console.WriteLine("There are {0} words in the string.", numberOfWords);
        }

        public override void SolveProblemThree() 
        {
            // Problem Four Tier One
            Console.WriteLine("The given string without the vowels follows.");
            for (int i = 0; i < A.Count; ++i)
            {
                if (!IsVowel(A[i]))
                {
                    Console.Write(A[i]);
                }
            }
            Console.Write("\n");
        }

        // Check if a character is vowel
        bool IsVowel(char a)
        {
            return "aeiou".Contains(a);
        }
    }
}
