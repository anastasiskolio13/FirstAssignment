using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierTwoProblemTwo
    {
        public static int SolveT2P2(List<int> listOfNumbers)
        {
            int sumOfSquaresOfPrimeNumbers = 0;
            for (int i = 0; i < listOfNumbers.Count; ++i)
            {
                if (IsPrime(listOfNumbers[i]))
                {
                    sumOfSquaresOfPrimeNumbers += listOfNumbers[i] * listOfNumbers[i];
                }
            }
            return sumOfSquaresOfPrimeNumbers;
        }

        // Primality Test of a number in O(Math.Sqrt(a)) time
        public static bool IsPrime(int a)
        {
            for (int b = 2; b * b <= a; ++b)
            {
                if (a % b == 0)
                {
                    return false;
                }
            }
            return a >= 2;
        }
    }
}
