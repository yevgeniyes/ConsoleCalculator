using System;
using System.IO;

namespace ConsoleCalculator
{
    internal class CopyOperation : FileOperationBase
    {
        private bool fileIsCopied;

        //Perform copy operation
        public override string GetFileResult(string[] splitedInput)
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
