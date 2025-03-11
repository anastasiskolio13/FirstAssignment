using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class Program
    {
        public static void Main()
        {
            SolverOne firstBunch = new SolverOne();
            firstBunch.ReadInput();
            firstBunch.SolveProblems();

            SolverTwo secondBunch = new SolverTwo();
            secondBunch.ReadInput();
            secondBunch.SolveProblems();

            SolverThree thirdBunch = new SolverThree();
            thirdBunch.ReadInput();
            thirdBunch.SolveProblems();
        }
    }
}
