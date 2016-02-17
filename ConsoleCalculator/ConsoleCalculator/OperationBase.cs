using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class OperationBase
    {
        public double checkValue;
        public bool isValid = true;

        public OperationBase(string[] str)
        {
            CheckValues(str);
        }

        //Checking correctness of numerical data
        public virtual void CheckValues(string[] str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (!double.TryParse(str[i], NumberStyles.Number, CultureInfo.InvariantCulture, out checkValue))
                {
                    Console.WriteLine(OperationProcessor.ERROR_WRONG);
                    isValid = false;
                    break;
                }
            }
        }
        public abstract double GetResult(string[] splitedString);
    }
}
