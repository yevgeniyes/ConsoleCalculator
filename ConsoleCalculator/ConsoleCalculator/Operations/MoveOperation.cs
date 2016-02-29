using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class MoveOperation : OperationBase
    {
        private bool fileIsMoved;

        //Perform move operation
        public override string GetResult(string[] splitedInput)
        {
            string file = splitedInput[1];
            string movedFile = splitedInput[2];
            fileIsMoved = false;

            try
            {
                File.Move(file, movedFile);
                fileIsMoved = true;
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
            if (fileIsMoved)
                Console.WriteLine("Result: " + result + " was moved\n");
        }
    }
}
