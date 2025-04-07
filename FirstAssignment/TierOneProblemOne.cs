using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierOneProblemOne
    {
        public static int SolveT1P1(List<char> listOfCharacters)
        {
            int occurrences = 0;
            for (int i = 0; i < listOfCharacters.Count; ++i)
            {
                if (listOfCharacters[i] == 'f')
                {
                    ++occurrences;
                }
            }
            return occurrences;
        }
    }
}
