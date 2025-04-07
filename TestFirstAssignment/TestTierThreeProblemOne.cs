namespace TestFirstAssignment
{
    public class TestTierThreeProblemOne
    {
        [Fact]
        public static void TestT3P1()
        {
            List<string> in1 = new List<string> { "savvas", "aba", " ", "a", "xrhstos", "xrhst", "ΝΙΨΟΝΑΝΟΜΗΜΑΤΑΜΗΜΟΝΑΝΟΨΙΝ", "ΝΙΨΟΝ ΑΝΟΜΗΜΑΤΑ ΜΗ ΜΟΝΑΝ ΟΨΙΝ"};
            List<string> out1 = FirstAssignment.TierThreeProblemOne.SolveT3P1(in1);
            List<string> exp1 = new List<string> { "savvas", "aba", " ", "a", "ΝΙΨΟΝΑΝΟΜΗΜΑΤΑΜΗΜΟΝΑΝΟΨΙΝ" };
            Assert.Equal(exp1, out1);
        }
    }
}
