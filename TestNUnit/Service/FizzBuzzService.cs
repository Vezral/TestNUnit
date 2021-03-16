using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNUnit.Service
{
    public class FizzBuzzService
    {
        public string Ask(int number)
        {
            var returnString = String.Empty;

            if (number % 3 == 0)
                returnString += "Fizz";
            if (number % 5 == 0)
                returnString += "Buzz";

            return returnString;
        }
    }
}
