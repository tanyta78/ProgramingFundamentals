﻿namespace _4.Elevator
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
