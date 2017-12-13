using System.Collections.Generic;
using NUnit.Framework;
using Sum;

namespace TestSum
{
    [TestFixture]
    public class SumUtilTest
    {
        [Test]
        public void SumUp0() //with multiple elements
        {
            List<int> testList = new List<int>() { 3, 6, 9, 8 };

            int result = SumMethod.SumUp(testList);

            Assert.AreEqual(26, result);
        }

        [Test]
        public void SumUp1() //with empty list
        {
            List<int> testList = new List<int>();

            int result = SumMethod.SumUp(testList);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void SumUp2() //with single element
        {
            List<int> testList = new List<int>() { 48 };

            int result = SumMethod.SumUp(testList);

            Assert.AreEqual(48, result);
        }

        [Test]
        public void SumUp3() //with null value
        {
            List<int> testList = new List<int>() { };
            testList = null;
            //var result = SumMethod.SumUp(testList);

            Assert.AreEqual(null, testList);
        }
    }
}
