namespace Calculator.Business
{
    public class Calculator : ICalculator
    {
        public float CalculateEquation(string equation)
        {
            decimal result = 0;
            double num1, num2;
            var equationSplit = equation.Split(' ');
            num1 = float.Parse(equationSplit[0]); num2 = float.Parse(equationSplit[2]);
            switch (equationSplit[1])
            {
                case "+":
                {
                    result = (decimal)Add((float)num1, (float)num2);
                    break;
                }
                case "-":
                {
                    result = (decimal)Subtract((float)num1, (float)num2);
                    break;
                }
                case "/":
                {
                    result = (decimal)Divide((float)num1, (float)num2);
                    break;
                }
                case "*":
                {
                    result = (decimal)Multiply((float)num1, (float)num2);
                    break;
                }
            }

            return (float)result;
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
