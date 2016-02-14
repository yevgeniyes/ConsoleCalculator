using System;
using System.Globalization;

namespace ConsoleCalculator
{
    class Calculations
    {
        public static double Sum(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedString.Length - 1; i++)
            {
                value = value + double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }

        public static double Subtract(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedString.Length - 1; i++)
            {
                value = value - double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }

        public static double Multiply(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedString.Length - 1; i++)
            {
                value = value * double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }
        public static double Divide(string[] splitedString)
        {
            double value = double.Parse(splitedString[1], CultureInfo.InvariantCulture);

            for (int i = 1; i < splitedString.Length - 1; i++)
            {
                value = value / double.Parse(splitedString[i + 1], CultureInfo.InvariantCulture);
            }
            return value;
        }
    }
}
