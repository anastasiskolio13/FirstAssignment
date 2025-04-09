namespace TestFirstAssignment
{
    public class TestTierOneProblemFour
    {
        [Fact]
        public static void TestT1P4()
        {
            List<char> in1 = new List<char> { 'a', 'b', 'u', 'g', 'h' };
            List<char> in2 = new List<char> { };
            List<char> out1 = FirstAssignment.TierOneProblemFour.SolveT1P4(in1);
            List<char> out2 = FirstAssignment.TierOneProblemFour.SolveT1P4(in2);
            List<char> exp1 = new List<char> { 'b', 'g', 'h' };
            List<char> exp2 = new List<char> { };
            Assert.Multiple(
                () => Assert.Equal(exp1, out1),
                () => Assert.Equal(exp2, out2)
            );

        }
    }
}
