using FluentAssertions;
using Xunit;

namespace ProjectEuler.UnitTests
{
    public class HelperTests
    {
        [Fact]
        public void IsPalindrome_Success()
        {
            AssertIsPalindrome(1331, true);
        }

        [Fact]
        public void IsPalindrome_Fail()
        {
            AssertIsPalindrome(1337, false);
        }

        [Fact]
        public void IsPrime_Success()
        {
            AssertIsPrime(48527, true);
        }

        [Fact]
        public void IsPrime_Fail()
        {
            AssertIsPrime(48521, false);
        }

        [Fact]
        public void IsPythagoreanTriplet_Success()
        {
            AssertIsPythagoreanTriplet(3, 4, 5, true);
        }

        [Fact]
        public void IsPythagoreanTriplet_Fail()
        {
            AssertIsPythagoreanTriplet(15, 16, 17, false);
        }

        [Fact]
        public void GetDivisorsCount_Few()
        {
            AssertGetDivisorsCount(6, 4);
        }

        [Fact]
        public void GetDivisorsCount_Many()
        {
            AssertGetDivisorsCount(28, 6);
        }

        private static void AssertIsPalindrome(int number, bool expectedResult)
        {
            bool actualResult = Helper.IsPalindrome(number);
            actualResult.Should().Be(expectedResult);
        }

        private static void AssertIsPrime(int number, bool expectedResult)
        {
            bool actualResult = Helper.IsPrime(number);
            actualResult.Should().Be(expectedResult);
        }

        private static void AssertIsPythagoreanTriplet(int a, int b, int c, bool expectedResult)
        {
            bool actualResult = Helper.IsPythagoreanTriplet(a, b, c);
            actualResult.Should().Be(expectedResult);
        }

        private static void AssertGetDivisorsCount(int number, int expectedCount)
        {
            int actualCount = Helper.GetDivisorsCount(number);
            actualCount.Should().Be(expectedCount);
        }
    }
}