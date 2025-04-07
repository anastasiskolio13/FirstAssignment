using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment
{
    public class TierOneProblemThree
    {
        public static List<string> SolveT1P3(List<string> listOfStrings)
        {
            List<string> listOfStringsContainingGivenCharacter = new List<string>();
            for (int i = 0; i < listOfStrings.Count; ++i)
            {
                if (listOfStrings[i].Contains('o'))
                {
                    listOfStringsContainingGivenCharacter.Add(listOfStrings[i]);
                }
            }
            return listOfStringsContainingGivenCharacter;
        }
    }
}
