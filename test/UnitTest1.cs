using NUnit.Framework;

namespace FizzBuzzTest
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
            Assert.AreEqual("2", FizzBuzz.Program.FizzBuzz(2));
            Assert.AreEqual("Fizz", FizzBuzz.Program.FizzBuzz(3));
            Assert.AreEqual("4", FizzBuzz.Program.FizzBuzz(4));
            Assert.AreEqual("Buzz", FizzBuzz.Program.FizzBuzz(5));
            Assert.AreEqual("Fizz", FizzBuzz.Program.FizzBuzz(6));
            Assert.AreEqual("FizzBuzz", FizzBuzz.Program.FizzBuzz(15));
        }
    }
}