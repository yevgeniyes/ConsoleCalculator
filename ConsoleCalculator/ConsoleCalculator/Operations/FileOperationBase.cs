using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class FileOperationBase : OperationBase
    {
        //Check and perform command, print result if comleted
        public override void Execute(string[] splitedInput)
        {
            string result = null;

            if (CheckStrings(splitedInput))
                result = GetFileResult(splitedInput);

            if (result != null) PrintResult(result);
        }

        //Checking input correctness
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
        public abstract string GetFileResult(string[] splitedInput);
    }
}
