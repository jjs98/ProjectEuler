using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem010 : Problem
    {
        public override string Name => "Summation of primes";

        public override string Description => """
                                              The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

                                              Find the sum of all the primes below two million.
                                              """;

        public override string Solve()
        {
            long result = 2;
            for (var i = 3; i < 2000000; i+=2)
            {
                if (Helper.IsPrime(i))
                {
                    result += i;
                }
            }

            return result.ToString();
        }
    }
}
