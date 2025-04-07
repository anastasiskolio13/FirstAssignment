using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierTwoProblemOne
    {
        public static float? SolveT2P1(List<int> listOfNumbers)
        {
            int sumOfEvenNumbersDivisibleByFive = 0;
            int countOfEvenNumbersDivisibleByFive = 0;
            for (int i = 0; i < listOfNumbers.Count; ++i)
            {
                if (listOfNumbers[i] % 2 == 0 && listOfNumbers[i] % 5 == 0)
                {
                    sumOfEvenNumbersDivisibleByFive += listOfNumbers[i];
                    countOfEvenNumbersDivisibleByFive += 1;
                }
            }
            if (countOfEvenNumbersDivisibleByFive == 0)
            {
                return null;
            }
            else
            {
                float AverageOfEvenNumbersDivisibleByFive = (float)sumOfEvenNumbersDivisibleByFive / countOfEvenNumbersDivisibleByFive;
                return AverageOfEvenNumbersDivisibleByFive;
            }
        }
    }
}
