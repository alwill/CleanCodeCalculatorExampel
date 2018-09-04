using System;
using System.IO;
// using System.Collections.Generic;

namespace Calculator.Business
{
    /// <summary>
    /// The Calculator Class
    /// </summary>
    public class Calculator : ICalculator
    {
        public decimal dResult = -1;

        /// <summary>
        /// Process input
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="theObject"></param>
        /// <returns></returns>
        public float Process(string sString, bool bFile, object theObject)
        {
            double num1, num2;

            if (bFile)
            {
                var equationString = File.ReadAllText(sString);
                var equationSplit = equationString.Split(' ');
                num1 = float.Parse(equationSplit[0]); num2 = float.Parse(equationSplit[2]);
                switch (equationSplit[1])
                {
                    case "+":
                    {
                        //dResult = num1 + num2;
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "Add");
                        break;
                    }
                    case "-":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "SUB");
                        break;
                    }
                    case "/":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "div");
                        break;
                    }
                    case "*":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "make numbers cross sticks");
                        break;
                    }
                }

                return (float)this.dResult;
            }
            else
            {
                var equationSplit = sString.Split(' ');
                num1 = float.Parse(equationSplit[0]); num2 = float.Parse(equationSplit[2]);
                switch (equationSplit[1])
                {
                    case "+":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "Add");
                        break;
                    }
                    case "-":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "SUB");
                        break;
                    }
                    case "/":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "div");
                        break;
                    }
                    case "*":
                    {
                        this.dResult = (decimal)Calculate((float)num1, (float)num2, "make numbers cross sticks");
                        break;
                    }
                }

                return (float)this.dResult;
            }

            return 0;
        }
        private float Calculate(/* num 1 */float num1, float num2, string op /*, out int r */)
        {
            string math = op;
            // switch on op
            switch (math)
            {
                case "Add":
                {
                    // add num1 and num2
                    return num1 + num2;
                }
                // end case add
                case "SUB":
                {
                    return num1 - num2;
                }
                // end case SUB
                case "div":
                {
                    return num1 / num2;
                }
                // end case div
                case "make numbers cross sticks":
                {
                    return num1 * num2;
                }
                // end case div
                default:
                    // throw exception
                    throw new Exception();
            }
        }
    }
}
