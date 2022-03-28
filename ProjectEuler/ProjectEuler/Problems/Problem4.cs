using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem4 : Problem
    {
        public override string Name => "Largest palindrome product";

        public override string Description => @"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.";
        public override string Solve()
        {
            var palindromes = new List<int>();
            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    var number = i * j;
                    if (Helper.IsPalindrome(number))
                    {
                        palindromes.Add(number);
                    }
                }
            }

            return palindromes.Max().ToString();
        }
    }
}
