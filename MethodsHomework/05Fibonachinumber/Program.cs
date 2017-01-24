using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Fibonachinumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a method Fib(n) that calculates the nth Fibonacci number. 
            int inputNumber = int.Parse(Console.ReadLine());
            Fib(inputNumber);

        }

        private static void Fib(int n)
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
