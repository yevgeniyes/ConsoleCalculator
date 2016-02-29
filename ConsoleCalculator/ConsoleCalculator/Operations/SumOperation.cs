using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class SumOperation : OperationBase
    {
        //Perform sum operation
        public override string GetResult(string[] splitedInput)
        {
            double value = double.Parse(splitedInput[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedInput.Length - 1; i++)
            {
                value = value + double.Parse(splitedInput[i + 1], CultureInfo.InvariantCulture);
            }
            return value.ToString();
        }
    }
}
