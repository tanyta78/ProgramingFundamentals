namespace _7.Greeting
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Write a program that enters first name, last name and age and 
            //prints "Hello, <first name> <last name>. You are <age> years old.". Use interpolated strings.

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}
