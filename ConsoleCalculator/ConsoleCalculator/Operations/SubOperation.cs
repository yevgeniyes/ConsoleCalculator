using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class SubOperation : OperationBase
    {
        //Perform subtraction operation
        public override double GetResult(string[] splitedInput)
        {
            double value = double.Parse(splitedInput[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedInput.Length - 1; i++)
            {
                value = value - double.Parse(splitedInput[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }
    }
}
