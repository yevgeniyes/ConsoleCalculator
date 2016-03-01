using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal abstract class OperationBase
    {
        //Template of operation completion: check input, get result, print result
        public void CompleteOperation(string[] splitedInput, string operationTag)
        {
            string result = null;

            switch (operationTag)
            {
                case "math":
                    if (CheckValues(splitedInput))
                    {
                        result = GetResult(splitedInput);
                    }
                    break;

                case "file":
                    if (CheckStrings(splitedInput))
                    {
                        result = GetResult(splitedInput);
                    }
                    break;
            }

            if(result != null) PrintResult(result);

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

        public virtual bool CheckStrings(string[] splitedInput)
        {
            if (splitedInput.Length == 3 && splitedInput[1].Contains(@":\") && splitedInput[2].Contains(@":\"))
                return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform operation: overriden for each Operations class
        public abstract string GetResult(string[] splitedInput);

        //Print result
        public virtual void PrintResult(string result)
        {
            Console.WriteLine("Result: " + result + "\n");
        }
    }
}
