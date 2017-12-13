using System.Collections.Generic;
using NUnit.Framework;
using Anagram;

namespace TestSum
{
    [TestFixture]
    public class SumUtilTest
    {
        [Test]
        public void IsAnagram0()
        {
            bool result =  AnagramMethod.IsAnagram("method   Test", "Methodtest");

            Assert.True(result);
            


        }    
    }
}
