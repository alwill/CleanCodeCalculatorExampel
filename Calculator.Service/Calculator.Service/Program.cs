using System;
using System.IO;
using System.Linq;
using Calculator.Business;
using Newtonsoft.Json;

namespace Calculator.Service
{
    class Program
    {
        static void Main(string[] args)
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
                                              "must be seperated by a space.");
                            break;
                    }
                    case "file":
                        {
                            Console.WriteLine("File path:");
                            var filePath = Console.ReadLine();
                            var equationString = File.ReadAllText(filePath);
                            var equationSplit = equationString.Split(" ");
                            var equationResult = theObject.Proccess(
                                float.Parse(equationSplit[0]),
                                float.Parse(equationSplit[2]), 
                                equationSplit[1]);
                            Console.WriteLine(equationResult);
                            break;
                        }
                    default:
                        var equation = userInput.Split(" ");
                        var result = theObject.Proccess(float.Parse(equation[0]), 
                                           float.Parse(equation[2]), 
                                           equation[1]);
                        Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}
