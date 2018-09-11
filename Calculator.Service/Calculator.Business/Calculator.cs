// using System.Collections.Generic;

namespace Calculator.Business
{
    /// <summary>
    /// The Calculator Class
    /// </summary>
    public class Calculator : ICalculator
    {
        public decimal Result = -1;

        /// <summary>
        /// Process input
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="theObject"></param>
        /// <returns></returns>
        public float Process(string equation)
        {
            double num1, num2;
            var equationSplit = equation.Split(' ');
            num1 = float.Parse(equationSplit[0]); num2 = float.Parse(equationSplit[2]);
            switch (equationSplit[1])
            {
                case "+":
                {
                    this.Result = (decimal)Add((float)num1, (float)num2);
                    break;
                }
                case "-":
                {
                    this.Result = (decimal)Subtract((float)num1, (float)num2);
                    break;
                }
                case "/":
                {
                    this.Result = (decimal)Divide((float)num1, (float)num2);
                    break;
                }
                case "*":
                {
                    this.Result = (decimal)Multiply((float)num1, (float)num2);
                    break;
                }
            }

            return (float)this.Result;
        }

        private float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        private float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        private float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        private float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
    }
}
