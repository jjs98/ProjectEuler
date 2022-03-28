﻿using ProjectEuler.Problems.Interfaces;
using System.ComponentModel.Composition;

namespace ProjectEuler.Problems
{
    [Export(typeof(IProblem))]
    internal class Problem3 : Problem
    {
        public override string Name => "Largest prime factor";

        public override string Description => @"The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?";
        public override string Solve()
        {
            long result = 0;
            long nummberToCheck = 600851475143;
            bool continueSearch = true;
            while (continueSearch)
            {
                result = Helper.DevideByPrimeNumber(nummberToCheck);
                if (Helper.IsPrime(result))
                {
                    continueSearch = false;
                }
                else
                {
                    nummberToCheck = result;
                }
            }

            return result.ToString();
        }
    }
}
