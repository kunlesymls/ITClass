namespace CalculatorLibrary
{
    public interface ISubtractionOperation
    {
        int SubstractTwoNumbers(int a, int b);
        double SubstractTwoNumbers(double a, double b);
        decimal SubstractTwoNumbers(decimal a, decimal b);
        decimal SubstractTwoNumbers(string a, string b);
    }
}
