using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierTwoProblemThree
    {
        public static int SolveT2P3(List<int> listOfNumbers)
        {
            int sumOfAbsoluteValuesOfNumbersDivisibleByThree = 0;
            for (int i = 0; i < listOfNumbers.Count; ++i)
            {
                if (listOfNumbers[i] % 3 == 0)
                {
                    sumOfAbsoluteValuesOfNumbersDivisibleByThree += Math.Abs(listOfNumbers[i]);
                }
            }
            return sumOfAbsoluteValuesOfNumbersDivisibleByThree;
        }
    }
}
