using System;
namespace Calculator.Business
{
    public class Calculator : ICalculator
    {
        public float Proccess(float num1, float num2, string operation)
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
                default:
                    throw new Exception();
            }
        }
    }
}
