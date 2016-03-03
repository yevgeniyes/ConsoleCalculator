using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class MoveOperation : FileOperationBase
    {
        //Perform move operation
        protected override void Execute(string[] splitedInput)
        {
            string file = splitedInput[1];
            string movedFile = splitedInput[2];

            try
            {
                File.Move(file, movedFile);
                Console.WriteLine("Result: " + file + " was moved\n");
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_FILE_CREATE_FAIL);
            }    
        }
    }
}
