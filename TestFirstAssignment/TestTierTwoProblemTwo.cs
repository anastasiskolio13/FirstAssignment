using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstAssignment
{
    public class TestTierTwoProblemTwo
    {
        [Fact]
        public static void TestT2P2()
        {
            List<int> in1 = new List<int> { 2, 3, 6, 8, 9, 10, 5 };
            List<int> in2 = new List<int> { 2, 3, 5, 7, 11 };
            List<int> in3 = new List<int> { -1, -1, -1, -1, -1 };
            List<int> in4 = new List<int> { };
            int out1 = FirstAssignment.TierTwoProblemTwo.SolveT2P2(in1);
            int out2 = FirstAssignment.TierTwoProblemTwo.SolveT2P2(in2);
            int out3 = FirstAssignment.TierTwoProblemTwo.SolveT2P2(in3);
            int out4 = FirstAssignment.TierTwoProblemTwo.SolveT2P2(in4);
            Assert.Multiple(
                () => Assert.Equal(38, out1),
                () => Assert.Equal(208, out2),
                () => Assert.Equal(0, out3),
                () => Assert.Equal(0, out4)
            );

        }
    }
}
