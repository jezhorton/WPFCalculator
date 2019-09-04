using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Calculator
    {
        public double Divide(double one, double two)
        {
            return one / two;
        }
        public double Add(double one, double two)
        {
            return one + two;
        }
        public double Multiply(double one, double two)
        {
            return one * two;
        }
        public double Subtract(double one, double two)
        {
            return one - two;
        }
    }
}
