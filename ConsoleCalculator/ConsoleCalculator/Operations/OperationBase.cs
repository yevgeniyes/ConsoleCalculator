using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal abstract class OperationBase
    {
        //Template of math operation completion: check input, get result, print result
        public void CompleteOperation(string[] splitedInput, string operationTag)
        {
            switch (operationTag)
            {
                case "math":
                    if (CheckValues(splitedInput))
                    {
                        var result = GetResult(splitedInput);
                        PrintResult(result);
                    }
                    break;

                case "file":
                    if (CheckStrings(splitedInput))
                    {
                        var result = GetResult(splitedInput);
                        PrintResult(result);
                    }
                    break;
            }

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
