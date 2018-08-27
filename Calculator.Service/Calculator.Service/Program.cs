using System;
using Calculator.Business;

namespace Calculator.Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ICalculator theObject = new Business.Calculator();
            while (true)
            {
                Console.WriteLine("Enter equation for processing:");

                var userInput = Console.ReadLine();

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
                        var equationResult = theObject.Proccess(filePath, true);
                        Console.WriteLine(equationResult);
                        break;
                    }
                    default:
                        var result = theObject.Proccess(userInput, false);
                        Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}
