using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber val1 = new ComplexNumber(7, 1);
            ComplexNumber val2 = new ComplexNumber(2, 6);
            // Add both of them
            ComplexNumber res = val1 + val2;
            Console.WriteLine("First: {0}", val1);
            Console.WriteLine("Second: {0}", val2);
            // display the result
            Console.WriteLine("Result (Sum): {0}", res);
            Console.ReadLine();Console.WriteLine("Hello World!");
        }
    }
}
