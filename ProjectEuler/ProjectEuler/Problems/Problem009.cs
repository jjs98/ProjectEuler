using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem009 : Problem
    {
        public override string Name => "Special Pythagorean triplet";

        public override string Description => @"A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.";

        public override string Solve()
        {
            int a = 1;
            int b = 2;
            int c = 1000 - (a + b);
            var result = 0;
            bool continueSearch = true;
            while (continueSearch)
            {
                if (Helper.IsPythagoreanTriplet(a, b, c) && a + b + c == 1000)
                {
                    result = (a * b * c);
                    continueSearch = false;
                }
                else
                {
                    if (b + 1 < c - 1)
                    {
                        b++;
                        c--;
                    }
                    else
                    {
                        a++;
                        b = a + 1;
                        c = 1000 - (a + b);
                    }
                }
            }

            return result.ToString();
        }
    }
}
