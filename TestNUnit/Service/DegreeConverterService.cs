using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNUnit.Service
{
    public class DegreeConverterService
    {
        public double ToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double ToCelcius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
