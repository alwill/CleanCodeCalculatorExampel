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
                            DisplayHelpMessage();
                            break;
                        }
                        case "file":
                        {
                            CalculateEquationFromFile();
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

        private static void CalculateEquationFromFile()
        {
            DisplayFileMessage();
            var filePath = GetFileInput();
            var equation = ReadEquationFromFile(filePath);
            var result = CalculateEquation(equation);
            Console.WriteLine(result);
        }
        private static void DisplayFileMessage()
        {
            Console.WriteLine("File path:");
        }

        private static string GetFileInput()
        {
            return Console.ReadLine();
        }

        private static string ReadEquationFromFile(string filePath)
        {
            var equation = File.ReadAllText(filePath);
            return equation;
        }
        private static void DisplayHelpMessage()
        {
            Console.WriteLine("We only do basic addition, " +
                              "multiplication, and division \n " +
                              "e.g. 5 + 2 \n Only 2 numbers and " +
                              "must be separated by a space.");
        }

        private static float CalculateEquation(string equation)
        {
            return Calculator.CalculateEquation(equation);
        }
    }
}
