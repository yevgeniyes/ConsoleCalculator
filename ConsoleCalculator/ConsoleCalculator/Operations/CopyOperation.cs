using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class CopyOperation : FileOperationBase
    {
        //Perform copy operation
        protected override void Execute(string[] splitedInput)
        {
            string file = splitedInput[1];
            string copiedFile = splitedInput[2];

            try
            {
                File.Copy(file, copiedFile);
                Console.WriteLine("Result: " + file + " was copied\n");
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_FILE_CREATE_FAIL);
            }    
        }
    }
}
