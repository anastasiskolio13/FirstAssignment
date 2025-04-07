namespace TestFirstAssignment
{
    public class TestTierTwoProblemThree
    {
        [Fact]
        public static void TestT2P3()
        {
            List<int> in1 = new List<int> { 0, 3, 0, 2, 1, -6 };
            List<int> in2 = new List<int> { -6, -1, -3, 3, 0, 0 };
            List<int> in3 = new List<int> { 1, 2, 4, 6, 8, 10 };
            List<int> in4 = new List<int> { };
            int out1 = FirstAssignment.TierTwoProblemThree.SolveT2P3(in1);
            int out2 = FirstAssignment.TierTwoProblemThree.SolveT2P3(in2);
            int out3 = FirstAssignment.TierTwoProblemThree.SolveT2P3(in3);
            int out4 = FirstAssignment.TierTwoProblemThree.SolveT2P3(in4);
            Assert.Multiple(
                () => Assert.Equal(9, out1),
                () => Assert.Equal(12, out2),
                () => Assert.Equal(6, out3),
                () => Assert.Equal(0, out4)
            );

        }
    }
}
