using System;
using System.IO;

namespace ConsoleCalculator
{
    class CopyOperation : OperationBase
    {
        private bool fileIsCopied;

        //Checking input correctness
        public override bool CheckValues(string[] splitedInput)
        {
            if (splitedInput.Length == 3 && splitedInput[1].Contains(@":\") && splitedInput[2].Contains(@":\"))
                return true;
            else
            {
                Console.WriteLine(Messages.ERROR_FILE_INVALID);
                return false;
            }
        }

        //Perform copy operation
        public override string GetResult(string[] splitedInput)
        {
            string file = splitedInput[1];
            string copiedFile = splitedInput[2];
            fileIsCopied = false;

            try
            {
                File.Copy(file, copiedFile);
                fileIsCopied = true;
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_FILE_CREATE_FAIL);
            }

            return file;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsCopied)
                Console.WriteLine("Result: " + result + " was copied\n");
        }
    }
}
