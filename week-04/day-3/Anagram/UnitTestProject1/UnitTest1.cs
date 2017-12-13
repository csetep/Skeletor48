using NUnit.Framework;
using Anagram;

namespace TestSum
{
    [TestFixture]
    public class SumUtilTest
    {
        [Test]
        public void IsAnagram0() // with equal strings
        {
            bool result = AnagramMethod.IsAnagram("MethodTest", "Methodtest");

            Assert.True(result);
        }

        [Test]
        public void IsAnagram1() //with non-equal strings
        {
            bool result = AnagramMethod.IsAnagram("MethodTest", "MuthudTust");

            Assert.False(result);
        }

        [Test]
        public void IsAnagram2() // checking case-sensitivity
        {
            bool result = AnagramMethod.IsAnagram("methodTEST", "METHODtest");

            Assert.True(result);
        }

        [Test]
        public void IsAnagram3() // with a few whitespace
        {
            bool result = AnagramMethod.IsAnagram("Methodtest", "M e Thod tes t  ");

            Assert.True(result);
        }
    }
}
