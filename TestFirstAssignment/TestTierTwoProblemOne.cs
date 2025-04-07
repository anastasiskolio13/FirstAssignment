namespace TestFirstAssignment
{
    public class TestTierTwoProblemOne
    {
        [Fact]
        public static void TestT2P1()
        {
            List<int> in1 = new List<int> { 10, 4, 1, 5, 30, 0 };
            List<int> in2 = new List<int> { 10, 100, 50, 20, 30 };
            List<int> in3 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> in4 = new List<int> { -10, -100, -3, -2, -10 };
            List<int> in5 = new List<int> { };
            float? out1 = FirstAssignment.TierTwoProblemOne.SolveT2P1(in1);
            float? out2 = FirstAssignment.TierTwoProblemOne.SolveT2P1(in2);
            float? out3 = FirstAssignment.TierTwoProblemOne.SolveT2P1(in3);
            float? out4 = FirstAssignment.TierTwoProblemOne.SolveT2P1(in4);
            float? out5 = FirstAssignment.TierTwoProblemOne.SolveT2P1(in5);
            float? exp1 = (float)40 / 3;
            float? exp2 = (float)210 / 5;
            float? exp3 = null;
            float? exp4 = (float)-120 / 3;
            float? exp5 = null;
            Assert.Multiple(
                () => Assert.Equal(exp1, out1), 
                () => Assert.Equal(exp2, out2),
                () => Assert.Equal(exp3, out3),
                () => Assert.Equal(exp4, out4),
                () => Assert.Equal(exp5, out5)
            );
        }
    }
}
