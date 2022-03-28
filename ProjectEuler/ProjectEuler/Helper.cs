namespace ProjectEuler
{
    public class Helper
    {
        public static bool IsPalindrome(int number)
        {
            var numberAsString = number.ToString();
            return numberAsString.SequenceEqual(numberAsString.Reverse());
        }

        public static long DevideByPrimeNumber(long number)
        {
            var prime = 2;
            while (number % prime != 0)
            {
                do
                {
                    prime++;
                }
                while (!IsPrime(prime));
            }
            return number / prime;
        }

        public static bool IsPrime(long number)
        {
            if (number == 2)
                return true;
            if (number <= 1 || number % 2 == 0)
                return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
