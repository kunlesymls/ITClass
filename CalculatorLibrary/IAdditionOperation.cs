namespace CalculatorLibrary
{
    public interface IAdditionOperation
    {
        int AddTwoNumbers(int a, int b);
        double AddTwoNumbers(double a, double b);
        decimal AddTwoNumbers(string a, string b);
        decimal AddTwoNumbers(decimal a, decimal b);
    }
}
