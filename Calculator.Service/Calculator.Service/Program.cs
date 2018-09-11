using System;
using System.IO;
using Calculator.Business;

namespace Calculator.Service
{
    internal class Program
    {
        private static readonly ICalculator Calculator = new Business.Calculator();
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter equation for processing:");

                var userInput = Console.ReadLine();
                try
                {
                    switch (userInput)
                    {
                        case "help":
                        {
                            Console.WriteLine("We only do basic addition, " +
                                              "multiplication, and division \n " +
                                              "e.g. 5 + 2 \n Only 2 numbers and " +
                                              "must be separated by a space.");
                            break;
                        }
                        case "file":
                        {
                            Console.WriteLine("File path:");
                            var filePath = Console.ReadLine();
                            var equationResult = CalculateEquationFromFile(filePath);
                            Console.WriteLine(equationResult);
                            break;
                        }
                        default:
                            var result = CalculateEquation(userInput);
                            Console.WriteLine(result);
                            break;
                    }
                }
                catch (Exception exception)
                {
                    // TODO log this. See issue #1
                    Console.WriteLine(exception);
                }
            }
        }

        private static float CalculateEquationFromFile(string filePath)
        {
            var equation = File.ReadAllText(filePath);
            return CalculateEquation(equation);
        }

        private static float CalculateEquation(string equation)
        {
            return Calculator.CalculateEquation(equation);
        }
    }
}
