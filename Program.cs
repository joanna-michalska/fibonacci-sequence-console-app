using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elementes in Fibonacci sequence: ");
            int.TryParse(Console.ReadLine(), out int fibonacciSequenceAmount);

            int a = 0;
            int b = 1;
            int sum;

            for (int i = 0; i < fibonacciSequenceAmount; i++)
            {
                Console.WriteLine(a);
                sum = a + b;
                a = b;
                b = sum;
            }
        }
    }
}
