using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        double checkedValue;
        bool isValid = true;

        //Checking correctness of numerical data
        public virtual bool CheckValues(string[] str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (!double.TryParse(str[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkedValue))
                {
                    Console.WriteLine(OperationProcessor.ERROR_WRONG);
                    isValid = false;
                    break;
                }
            }

            if (!isValid)
                return false;
            else
                return true;
        }
        public abstract double GetResult(string[] splitedString);
    }
}
