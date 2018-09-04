namespace Calculator.Business
{
    public interface ICalculator
    {
        float Process(string sString, bool bFile, object theObject);
    }
}
