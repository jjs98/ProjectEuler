using System.ComponentModel.Composition;

namespace ProjectEuler
{
    [Export(typeof(IProblem))]
    internal class Problem1 : IProblem
    {
        public int Number => 1;
        public string Name => "Multiples of 3 or 5";

        public string Description => @"If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.";

        public string Solve()
        {
            var sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }
}
