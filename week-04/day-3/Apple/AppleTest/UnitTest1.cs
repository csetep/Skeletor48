using System;
using NUnit.Framework;
using Apple;

namespace UnitTestApple
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetApple()
        {
            AppleClass apple1 = new AppleClass();

            Assert.AreEqual("apple", apple1.GetApple());
        }
    }
}
