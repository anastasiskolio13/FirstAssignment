using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierOneProblemTwo
    {
        public static int SolveT1P2(List<char> listOfCharacters)
        {
            int i = 0;
            int numberOfWords = 0;
            while (i < listOfCharacters.Count)
            {
                if (listOfCharacters[i] == ' ')
                {
                    ++i;
                    continue;
                }
                ++numberOfWords;
                int j = i;
                while (j < listOfCharacters.Count && listOfCharacters[j] != ' ')
                    ++j;
                i = j;
            }
            return numberOfWords;
        }
    }
}
