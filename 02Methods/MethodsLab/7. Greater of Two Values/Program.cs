using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int max = GetMax(first, second);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char maxChar = GetMax(firstChar,secondChar);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string maxString = GetMax(firstString,secondString);
                    Console.WriteLine(maxString);
                    break;
            }
        }

        private static int GetMax(int first, int second)
        {
            if (first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        private static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
