namespace TestFirstAssignment
{
    public class TestTierThreeProblemTwo
    {
        [Fact]
        public static void TestT3P2()
        {
            List<string> in1 = new List<string> { "abaa", "aba", "baa", " " , "xyz", "xzy" };
            List<string> out1 = FirstAssignment.TierThreeProblemTwo.SolveT3P2(in1);
            List<string> exp1 = new List<string> { "aba", "baa", "xyz", "xzy" };
            Assert.Equal(exp1, out1);
        }
    }
}
