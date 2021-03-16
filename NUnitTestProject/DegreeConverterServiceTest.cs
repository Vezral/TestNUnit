using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNUnit.Service;

namespace NUnitTestProject
{
    [TestFixture]
    public class DegreeConverterServiceTest
    {
        private DegreeConverterService _service;

        [SetUp]
        public void Setup()
        {
            _service = new DegreeConverterService();
        }

        [TearDown]
        public void TearDown()
        {
            _service = null;
        }

        [TestCase(36.7)]
        [TestCase(45)]
        public void DegreeConverter_DoubleConversionEqual_ReturnsTrue(double celsius)
        {
            var fahrenheit = _service.ToFahrenheit(celsius);
            var celsius2 = _service.ToCelcius(fahrenheit);

            Assert.That(celsius2, Is.EqualTo(celsius));
        }
        
        [Category("TestCalculation")]
        [TestCase(0, 32)]
        [TestCase(1, 33.8)]
        public void DegreeConverter_ToFahrenheit_ReturnsCorrectValue(double celsius, double expectedFahrenheit)
        {
            var result = _service.ToFahrenheit(celsius);

            Assert.That(result, Is.EqualTo(expectedFahrenheit).Within(0.01));
        }

        [Category("TestCalculation")]
        [TestCase(32, 0)]
        [TestCase(33.8, 1)]
        public void DegreeConverter_ToCelsius_ReturnsCorrectValue(double fahrenheit, double expectedCelsius)
        {
            var result = _service.ToCelcius(fahrenheit);

            Assert.That(result, Is.EqualTo(expectedCelsius).Within(0.01));
        }
    }
}
