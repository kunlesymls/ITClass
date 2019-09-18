using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public interface IBasicOperation : IAdditionOperation, ISubtractionOperation
    {
    }

    public interface IAdditionOperation
    {
        int AddTwoNumbers(int a, int b);
        double AddTwoNumbers(double a, double b);
        decimal AddTwoNumbers(decimal a, decimal b);
    }
    public interface ISubtractionOperation
    {
        int SubstractTwoNumbers(int a, int b);
        double SubstractTwoNumbers(double a, double b);
        decimal SubstractTwoNumbers(decimal a, decimal b);
    }
}
