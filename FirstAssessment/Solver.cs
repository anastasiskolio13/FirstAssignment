using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FirstAssessment
{
    abstract class Solver<T>
    {
        protected List<T> A;
        protected const int N = 5;
        public abstract void ReadInput();
        public abstract void SolveProblemOne();
        public abstract void SolveProblemTwo();
        public abstract void SolveProblemThree();
        public void SolveProblems()
        {
            SolveProblemOne();
            SolveProblemTwo();
            SolveProblemThree();
        }

    }
}
