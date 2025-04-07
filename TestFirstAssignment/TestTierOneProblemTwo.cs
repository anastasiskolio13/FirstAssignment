namespace TestFirstAssignment
{
    public class TestTierOneProblemTwo
    {
        [Fact]
        public static void TestT1P2()
        {
            List<char> in1 = new List<char> { 'g', 'i', 'w', 'r', 'g', 'o', 's' };
            List<char> in2 = new List<char> { 'a', 'b', 'a', ' ', 'b' };
            List<char> in3 = new List<char> { ' ', 'b', ' ', 'a' , ' ' };
            List<char> in4 = new List<char> { ' ', ' ', ' ' };
            List<char> in5 = new List<char> { 'a', ' ' };
            List<char> in6 = new List<char> { ' ', 'a' };
            int out1 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in1);
            int out2 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in2);
            int out3 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in3);
            int out4 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in4);
            int out5 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in5);
            int out6 = FirstAssignment.TierOneProblemTwo.SolveT1P2(in6);
            Assert.Multiple(
                () => Assert.Equal(1, out1),
                () => Assert.Equal(2, out2),
                () => Assert.Equal(2, out3),
                () => Assert.Equal(0, out4),
                () => Assert.Equal(1, out5),
                () => Assert.Equal(1, out6)
            );
        }

    }
}
