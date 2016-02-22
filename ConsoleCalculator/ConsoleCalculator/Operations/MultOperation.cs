using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class MultOperation : OperationBase
    {
        public override double GetResult(string[] splited)
        {
            double value = double.Parse(splited[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splited.Length - 1; i++)
            {
                value = value * double.Parse(splited[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }
    }
}
