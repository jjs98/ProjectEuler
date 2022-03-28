using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem007 : Problem
    {
        public override string Name => "10001st prime";

        public override string Description => @"By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?";

        public override string Solve()
        {
            var result = 1;
            var primeNumber = 0;
            while (primeNumber != 10001)
            {
                result++;
                if (Helper.IsPrime(result))
                    primeNumber++;
            }

            return result.ToString();
        }
    }
}
