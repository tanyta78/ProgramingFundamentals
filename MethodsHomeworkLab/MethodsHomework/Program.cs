using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
            string name = Console.ReadLine();
            MyMetod(name);


        }

        static void MyMetod(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
