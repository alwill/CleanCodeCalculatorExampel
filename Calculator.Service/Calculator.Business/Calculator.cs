using System;
using System.IO;

namespace Calculator.Business
{
    public class Calculator : ICalculator
    {
        public float Proccess(string input, bool fromFile)
        {
            if (fromFile)
            {
                var equationString = File.ReadAllText(input);
                var equationSplit = equationString.Split(' ');
                return Calculate(float.Parse(equationSplit[0]), float.Parse(equationSplit[2]), equationSplit[1]);
            }
            else
            {
                var equationSplit = input.Split(' ');
                return Calculate(float.Parse(equationSplit[0]), float.Parse(equationSplit[2]), equationSplit[1]);
            }
        }
        private float Calculate(float num1, float num2, string operation)
        {
            switch (operation)
            {
                case "+":
                {
                    return num1 + num2;
                }
                case "-":
                {
                    return num1 - num2;
                }
                case "/":
                {
                    return num1 / num2;
                }
                case "*":
                {
                    return num1 * num2;
                }
                default:
                    throw new Exception();
            }
        }
    }
}
