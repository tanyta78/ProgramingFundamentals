namespace _8.Letters_Change_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            char[] separator = new char[] { ' ', '\n', '\t' };
            string[] input = Console.ReadLine().Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal result = 0;
            int numberOfStrings = input.Length;
            for (int i = 0; i < numberOfStrings; i++)
            {
                string currentString = input[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                currentString = currentString.Remove(0, 1);
                currentString = currentString.Remove(currentString.Length - 1, 1);
                int number = int.Parse(currentString);
                if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    result += (decimal)number * (firstLetter - 'a' + 1);
                }
                else if (firstLetter >= 'A' && firstLetter <= 'Z')
                {
                    result += (decimal)number / (firstLetter - 'A' + 1);
                }
                if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    result += lastLetter - 'a' + 1;
                }
                else if (lastLetter >= 'A' && lastLetter <= 'Z')
                {
                    result -= lastLetter - 'A' + 1;
                }
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
