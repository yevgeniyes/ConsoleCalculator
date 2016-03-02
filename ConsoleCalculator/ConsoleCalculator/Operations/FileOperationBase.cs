using System;
using System.Globalization;

namespace ConsoleCalculator
{
    abstract class FileOperationBase : OperationBase
    {
        //Checking input correctness
        protected override bool Validate(string[] splitedInput)
        {
            if (splitedInput.Length == 3 && splitedInput[1].Contains(@":\") && splitedInput[2].Contains(@":\"))
                return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }
    }
}
