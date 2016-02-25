using System;
using System.IO;

namespace ConsoleCalculator
{
    class MoveOperation : OperationBase
    {
        private bool fileIsMoved;

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

        //Perform move operation
        public override string GetResult(string[] splitedInput)
        {
            string sourcePath = splitedInput[1];
            string destPath = splitedInput[2];
            fileIsMoved = false;

            try
            {
                File.Move(sourcePath, destPath);
                fileIsMoved = true;
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
            if (fileIsMoved)
                Console.WriteLine("Result: " + result + " was moved\n");
        }
    }
}
