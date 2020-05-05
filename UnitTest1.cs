using NUnit.Framework;

namespace ninjaplus_net
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var a = 5;
            var b = 5;
            var total = a + b;

            Assert.AreEqual(10, total);
        }
    }
}