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
                Console.WriteLine(OperationProcessor.ERROR_FILE_WRONG);
                return false;
            }
        }

        //Perform copy operation
        public override string GetResult(string[] splitedInput)
        {
            string sourcePath = splitedInput[1];
            string destPath = splitedInput[2];
            fileIsCopied = false;

            try
            {
                File.Copy(sourcePath, destPath);
                fileIsCopied = true;
            }
            catch
            {
                Console.WriteLine("Directory not found or file already exist. Check path and try again\n");
            }

            return sourcePath;
        }

        //Print result
        public override void PrintResult(string result)
        {
            if (fileIsCopied)
                Console.WriteLine("Result: " + result + " was copied\n");
        }
    }
}
