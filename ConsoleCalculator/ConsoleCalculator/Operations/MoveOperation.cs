using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class MoveOperation : FileOperationBase
    {
        private bool fileIsMoved;

        //Perform move operation
        public override void Execute(string[] splitedInput)
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

            if (fileIsMoved)
                Console.WriteLine("Result: " + file + " was moved\n");
        }
    }
}
