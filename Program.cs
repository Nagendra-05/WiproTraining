using System;
namespace Calculator
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.Write("enter 1st number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("enter 2nd number");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"sum of two numbers is:{a + b}");
        }
    }
}
