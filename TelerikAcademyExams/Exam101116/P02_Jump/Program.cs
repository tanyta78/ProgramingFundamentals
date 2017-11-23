using System;

namespace P02_Jump
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var index = 0;

            while (true)
            {
                if (char.IsDigit(input[index]))
                {
                    var valueOfNum = int.Parse(input[index].ToString());
                    if (valueOfNum == 0)
                    {
                        Console.WriteLine("Too drunk to go on after {0}!", index);
                        break;
                    }

                    if (valueOfNum % 2 == 0)
                    {
                        index += valueOfNum;
                    }
                    else
                    {
                        index -= valueOfNum;
                    }

                    if (index < 0 || index > input.Length - 1)
                    {
                        Console.WriteLine("Fell off the dancefloor at {0}!", index);
                        break;
                    }
                }
                else if (input[index].Equals('^'))
                {
                    Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", index);
                    break;
                }
            }
