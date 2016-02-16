using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class BaseClass
    {
        public virtual double GetResult(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);
            return value;
        }
    }
}
