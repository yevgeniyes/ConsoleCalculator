using System;
using System.Globalization;

namespace ConsoleCalculator
{
    internal class OperationProcessor
    {
        public OperationProcessor()
        {
            Console.WriteLine(Messages.INTRO_TEXT);
        }

        //Main logic: read, validate and split input, select operation, complete operation based on operation tag ("math" or "file")
        public void Run()
        {
            while (true)
            {
                var inputProcessor = new InputProcessor();
                string[] splitedInput = inputProcessor.ReadAndSplit();

                if (splitedInput == null) continue;

                string operation = splitedInput[0];

                var fabric = new OperationFabric();
                var selectedOperarion = fabric.SelectOperation(operation);

                if (selectedOperarion != null)
                {
                    selectedOperarion.CompleteOperation(splitedInput);
                }
            }
        }
    }
}
