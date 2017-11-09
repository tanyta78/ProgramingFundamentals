namespace MethodsHomework
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ////Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
            string name = Console.ReadLine();
            MyMetod(name);
        }

        public static void MyMetod(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}