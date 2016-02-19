using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        //Checking correctness of numerical data
        public virtual bool CheckValues(string[] str)
        {
            double checkedValue;

            for (int i = 1; i < str.Length; i++)
            {
                if (!double.TryParse(str[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkedValue))
                {
                    Console.WriteLine(OperationProcessor.ERROR_WRONG);
                    return false;
                }
            }
                return true;
        }
        public abstract double GetResult(string[] splitedString);
    }
}
