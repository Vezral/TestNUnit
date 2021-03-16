using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNUnit.Service;

namespace NUnitTestProject
{
    [Category("FizzBuzz")]
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _service { get; set; }

        [SetUp]
        public void Setup()
        {
            _service = new FizzBuzzService();
        }

        [TearDown]
        public void TearDown()
        {
            _service = null;
        }

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(19, "")]
        public void TestFizzBuzz_Input_CorrectOutput(int number, string expectedOutput)
        {
            var result = _service.Ask(number);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
