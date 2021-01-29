using System;

namespace SharpCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataConverter dataConverter = new DataConverter();
                TheCalc theCalc = new TheCalc();

                double firstNumber = dataConverter.ConvertToNumeric(Console.ReadLine());
                double secondNumber = dataConverter.ConvertToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = theCalc.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
