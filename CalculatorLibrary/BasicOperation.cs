namespace CalculatorLibrary
{
    public class BasicOperation : IBasicOperation
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddTwoNumbers(double a, double b)
        {
            return a + b;
        }

        public decimal AddTwoNumbers(decimal a, decimal b)
        {
            return a + b;
        }
        public decimal AddTwoNumbers(string a, string b)
        {
            return ConvertStringToDecimal(a) + ConvertStringToDecimal(b);
        }



        public decimal ConvertStringToDecimal(string stringValue)
        {
            return decimal.Parse(stringValue);
        }

        public int SubstractTwoNumbers(int a, int b)
        {
            throw new System.NotImplementedException();
        }

        public double SubstractTwoNumbers(double a, double b)
        {
            throw new System.NotImplementedException();
        }
        public decimal SubstractTwoNumbers(string a, string b)
        {
            return ConvertStringToDecimal(a) - ConvertStringToDecimal(b);
        }

        public decimal SubstractTwoNumbers(decimal a, decimal b)
        {
            throw new System.NotImplementedException();
        }
    }
}
