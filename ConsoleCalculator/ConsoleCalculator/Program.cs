using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var processor = new OperationProcessor();
                processor.Run();
            }
            catch
            {
                Console.WriteLine(Messages.ERROR_CRITICAL);
                Console.ReadKey();
            }
        }
    }
}
