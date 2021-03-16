using NUnit.Framework;
using System;
using TestNUnit.Service;

namespace NUnitTestProject
{
    [TestFixture]
    public class TestServiceTests
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            int result = TestService.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void ParsePort_InvalidFormat_ThrowsInvalidFormatException()
        {
            TestDelegate action = () => TestService.ParsePort("1");
            Assert.Throws<FormatException>(action);
        }
    }
}