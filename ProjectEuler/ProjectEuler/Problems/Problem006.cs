using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem006 : Problem
    {
        public override string Name => "Sum square difference";

        public override string Description => """
                                              The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385

                                              The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025

                                              Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.

                                              Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
                                              """;

        public override string Solve()
        {
            double sum = 0;
            var square = 0;
            for (var i = 1; i <= 100; i++)
            {
                sum += Math.Pow(i, 2);
                square += i;
            }

            var result = Math.Pow(square, 2) - sum;

            return result.ToString();
        }
    }
}
