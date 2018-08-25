using System;

namespace Calculator.Business
{
    public interface ICalculator
    {
        float Proccess(float num1, float num2, string operation);
    }
}
