using NUnit.Framework;
using SomeLibrary;

namespace SomeLibTests
{
    public class Tests
    {
        [Test]
        public void Test_passing()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_build()
        {
            var bld = new GreetingsBuilder("world");
            Assert.AreEqual("Hello, world!", bld.Build());
        }
    }
}