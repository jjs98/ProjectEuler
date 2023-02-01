using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.UnitTests
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void IsPalindrome_Success()
        {
            AssertIsPalindrome(1331, true);
        }

        [TestMethod]
        public void IsPalindrome_Fail()
        {
            AssertIsPalindrome(1337, false);
        }

        [TestMethod]
        public void IsPrime_Success()
        {
            AssertIsPrime(48527, true);
        }

        [TestMethod]
        public void IsPrime_Fail()
        {
            AssertIsPrime(48521, false);
        }

        [TestMethod]
        public void IsPythagoreanTriplet_Success()
        {
            AssertIsPythagoreanTriplet(3, 4, 5, true);
        }

        [TestMethod]
        public void IsPythagoreanTriplet_Fail()
        {
            AssertIsPythagoreanTriplet(15, 16, 17, false);
        }

        [TestMethod]
        public void GetDivisorsCount_Few()
        {
            AssertGetDivisorsCount(6, 4);
        }

        [TestMethod]
        public void GetDivisorsCount_Many()
        {
            AssertGetDivisorsCount(28, 6);
        }

        private static void AssertIsPalindrome(int number, bool expectedResult)
        {
            bool actualResult = Helper.IsPalindrome(number);
            Assert.AreEqual(actualResult, expectedResult);
        }

        private static void AssertIsPrime(int number, bool expectedResult)
        {
            bool actualResult = Helper.IsPrime(number);
            Assert.AreEqual(actualResult, expectedResult);
        }

        private static void AssertIsPythagoreanTriplet(int a, int b, int c, bool expectedResult)
        {
            bool actualResult = Helper.IsPythagoreanTriplet(a, b, c);
            Assert.AreEqual(actualResult, expectedResult);
        }

        private static void AssertGetDivisorsCount(int number, int expectedCount)
        {
            int actualCount = Helper.GetDivisorsCount(number);
            Assert.AreEqual(actualCount, expectedCount);
        }
    }
}