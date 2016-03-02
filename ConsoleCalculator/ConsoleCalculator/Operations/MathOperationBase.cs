using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class MathOperationBase : OperationBase
    {
        //Checking input correctness
        protected override bool Validate(string[] splitedInput)
        {
            double checkedValue;

            for (int i = 1; i < splitedInput.Length; i++)
            {
                if (!double.TryParse(splitedInput[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkedValue))
                {
                    Console.WriteLine(Messages.ERROR_CALC_INVALID);
                    return false;
                }
            }
            return true;
        }
    }
}
