using CalculatorLibrary;
using System;

namespace ITClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("type a number!");
            //// this line will get user input
            //int n = int.Parse(Console.ReadLine());
            ////this line will check if it is divisible by 5 and 7
            //if (n % 5 == 0 && n % 7 == 0)
            //{
            //    Console.WriteLine("the number is divisible by 5 and 7");
            //}
            //else
            //{
            //    Console.WriteLine("the number is NOT divisible by 5 and 7");
            //}
            //checkingPrimeN();
        }

        static void checkingPrimeN()
        {
            Console.WriteLine("enter first number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            Double b = double.Parse(Console.ReadLine());


            IBasicOperation calculator = new BasicOperation();

            Console.WriteLine($"The addition of a nd b is {calculator.AddTwoNumbers(a,b)}");
        }
    }
}
