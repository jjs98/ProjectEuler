using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem005 : Problem
    {
        public override string Name => "Smallest multiple";

        public override string Description => """
                                              2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

                                              What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
                                              """;

        public override string Solve()
        {
            var result = 0;
            bool continueSearch = true;
            while (continueSearch)
            {
                bool continueDivision = true;
                result += 20;
                for (int i = 3; i < 20; i++)
                {
                    if (i == 4 || i == 5 || i == 10)
                        continue;

                    if (continueDivision && result % i == 0)
                    {
                        continueSearch = false;
                    }
                    else
                    {
                        continueDivision = false;
                        continueSearch = true;
                    }
                }
            }

            return result.ToString();
        }
    }
}
