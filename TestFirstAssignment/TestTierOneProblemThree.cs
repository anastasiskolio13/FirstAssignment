namespace TestFirstAssignment
{
    public class TestTierOneProblemThree
    {
        [Fact]
        public static void TestT1P3()
        {
            List<string> in1 = new List<string> { "xrhstos", " ", "giorgos", "maria"};
            List<string> in2 = new List<string> { };
            List<string> out1 = FirstAssignment.TierOneProblemThree.SolveT1P3(in1);
            List<string> out2 = FirstAssignment.TierOneProblemThree.SolveT1P3(in2);
            List<string> exp1 = new List<string> { "xrhstos", "giorgos" };
            List<string> exp2 = new List<string> { };
            Assert.Multiple(
                () => Assert.Equal(exp1, out1),
                () => Assert.Equal(exp2, out2)
            );
        }
    }
}
