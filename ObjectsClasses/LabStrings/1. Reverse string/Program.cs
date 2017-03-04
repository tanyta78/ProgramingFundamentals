using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
   public class Program
    {
        /// <summary>
        /// Write a program that reads a string from the console, reverses it and prints the result back at the console.
        /// </summary>
        /// <param name="args"></param>
       public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            var output =new String( input);
            Console.WriteLine(output);
        }
        public static void ReverseString()
        {

        }
    }
}
