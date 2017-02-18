namespace _3.Unicode_Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()

        ////    Write a program that converts a string to a sequence of Unicode character literals.
        {
            string textToConvert = Console.ReadLine();

            int len = textToConvert.Length;

            StringBuilder result = new StringBuilder();
            foreach (char c in textToConvert)
            {
                result.Append("\\u");
                result.Append(String.Format("{0:x4}", (int)c));
            }
            Console.WriteLine(result.ToString());
        }
    }
}