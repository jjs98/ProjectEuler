using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectEuler.UnitTests")]
namespace ProjectEuler
{
    internal static class Helper
    {
        internal static bool IsPalindrome(long number)
        {
            var numberAsString = number.ToString();
            return numberAsString.SequenceEqual(numberAsString.Reverse());
        }

        internal static bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        internal static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        internal static int GetDivisorsCount(long number)
        {
            int countOfDivisors = 1;
            for (long i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    countOfDivisors++;
                }
            }
            return countOfDivisors;
        }
    }
}
