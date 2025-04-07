namespace FirstAssignment
{
    public class TierOneProbleFour
    {
        public static List<char> SolveT1P4(List<char> listOfCharacters)
        {
            List<char> listOfCharactersWithoutVowels = new List<char>();
            for (int i = 0; i < listOfCharacters.Count; ++i)
            {
                if (!IsVowel(listOfCharacters[i]))
                {
                    listOfCharactersWithoutVowels.Add(listOfCharacters[i]);
                }
            }
            return listOfCharactersWithoutVowels;
        }

        // Check if a character is vowel
        public static bool IsVowel(char a)
        {
            return "aeiou".Contains(a);
        }
    }
}
