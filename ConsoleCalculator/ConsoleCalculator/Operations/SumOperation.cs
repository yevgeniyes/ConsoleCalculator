using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class SumOperation : OperationBase
    {
        public override double GetResult(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedString.Length - 1; i++)
            {
                value = value + double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }
    }
}
