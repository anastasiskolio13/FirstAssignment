namespace TestFirstAssignment
{
    public class TestTierOneProblemOne
    {
        [Fact]
        public static void TestT1P1()
        {
            List<char> in1 = new List<char> { 'a', 'f', 'f', ' ' };
            List<char> in2 = new List<char> { ' ', 'a' };
            List<char> in3 = new List<char>();
            int out1 = FirstAssignment.TierOneProblemOne.SolveT1P1(in1);
            int out2 = FirstAssignment.TierOneProblemOne.SolveT1P1(in2);
            int out3 = FirstAssignment.TierOneProblemOne.SolveT1P1(in3);
            Assert.Multiple(
                () => Assert.Equal(2, out1),
                () => Assert.Equal(0, out2),
                () => Assert.Equal(0, out3)
            );
        }
    }
}