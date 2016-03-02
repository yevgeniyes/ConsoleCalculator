using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class MathOperationBase : OperationBase
    {
        //Check and perform command, print result if comleted 
        public override void Execute(string[] splitedInput)
        {
            string result = null;

            if (CheckValues(splitedInput))
                result = GetMathResult(splitedInput);

            if (result != null) PrintResult(result);
        }

        //Checking input correctness
        public virtual bool CheckValues(string[] splitedInput)
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

        //Perform operation: overriden for each Operations class
        public abstract string GetMathResult(string[] splitedInput);
    }
}
