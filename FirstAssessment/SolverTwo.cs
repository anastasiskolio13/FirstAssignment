using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssessment
{
    class SolverTwo : Solver<int>
    {
        public SolverTwo()
        {
            A = new List<int>();
        }
        public override void ReadInput()
        {
            Console.WriteLine("Insert {0} integer(s):__", N);
            // Assuming the input is a sequence of integers
            for (int i = 0; i < N; ++i)
            {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
        }

        public override void SolveProblemOne()
        {
            // Problem One Tier Two
            int sumOfEvenNumbersDivisibleByFive = 0;
            int countOfEvenNumbersDivisibleByFive = 0;
            for (int i = 0; i < A.Count; ++i)
            {
                if (A[i] % 2 == 0 && A[i] % 5 == 0)
                {
                    sumOfEvenNumbersDivisibleByFive += A[i];
                    ++countOfEvenNumbersDivisibleByFive;
                }
            }
            if (countOfEvenNumbersDivisibleByFive == 0)
            {
                Console.WriteLine("There aren't any even numbers that are divisible by five (5) in the list.");
            }
            else
            {
                float AverageOfEvenNumbersDivisibleByFive = (float) sumOfEvenNumbersDivisibleByFive / countOfEvenNumbersDivisibleByFive;
                Console.WriteLine("The average of even numbers that are divisible by five (5) is {0}.", AverageOfEvenNumbersDivisibleByFive);
            }
        }

        public override void SolveProblemTwo()
        {
            // Problem Two Tier Two
            int sumOfSquaresOfPrimeNumbers = 0;
            for (int i = 0; i < A.Count; ++i)
            {
                if (IsPrime(A[i]))
                {
                    sumOfSquaresOfPrimeNumbers += A[i] * A[i];
                }
            }
            Console.WriteLine("The sum of squares of prime numbers is equal to {0}.", sumOfSquaresOfPrimeNumbers);
        }

        public override void SolveProblemThree()
        {
            // Problem Three Tier Two
            int sumOfAbsoluteValuesOfNumbersDivisibleByThree = 0;
            for (int i = 0; i < A.Count; ++i)
            {
                if (A[i] % 3 == 0)
                {
                    sumOfAbsoluteValuesOfNumbersDivisibleByThree += Math.Abs(A[i]);
                }
            }
            Console.WriteLine("The sum of absolute values of numbers divisible by three is equal to {0}.", sumOfAbsoluteValuesOfNumbersDivisibleByThree);
        }

        // Primality Test of a number in O(Math.Sqrt(a)) time
        bool IsPrime(int a)
        {
            for (int b = 2; b * b <= a; ++b)
            {
                if (a % b == 0)
                {
                    return false;
                }
            }
            return a >= 2;
        }
    }
}
