namespace _05Fibonachinumber
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            ////Define a method Fib(n) that calculates the nth Fibonacci number. 
            int inputNumber = int.Parse(Console.ReadLine());
            Fib(inputNumber);
        }

        public static void Fib(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(b);
        }
    }
}
