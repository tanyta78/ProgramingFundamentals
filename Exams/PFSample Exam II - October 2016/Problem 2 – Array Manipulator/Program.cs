using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string comandInfo = Console.ReadLine();
            int[] result = new int[myArr.Length];
            while (!comandInfo.Equals("end"))
            {
                ////read first comand
                string[] comand = comandInfo.Split(' ');
                switch (comand[0])
                {
                    case "exchange":
                        myArr = ExchangeArray(myArr, comand);
                        break;
                    case "max":
                        PrintMaxIndex(myArr, comand);
                        break;
                    case "min":
                        PrintMinIndex(myArr, comand);
                        break;
                    case "first":
                        PrintFirstNElements(myArr, comand);
                        break;
                    case "last":
                        PrintLastNElements(myArr, comand);
                        break;
                }

                comandInfo = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", myArr)}]");

        }

        private static void PrintLastNElements(int[] myArr, string[] comand)
        {
            int count = int.Parse(comand[1]);
            string type = comand[2];
            if (count > myArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                switch (type)
                {
                    case "odd":
                        if (!myArr.Any(n => n % 2 == 1))
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (myArr.Where(n => n % 2 == 1).Count() < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 1).ToArray())}]");
                            }
                            else
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 1).ToArray().Reverse().Take(count).Reverse())}]");
                        }

                        break;
                    case "even":
                        if (!myArr.Any(n => n % 2 == 0))
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (myArr.Where(n => n % 2 == 0).Count() < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 0).ToArray())}]");
                            }
                            else
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 0).ToArray().Reverse().Take(count).Reverse())}]");
                        }


                        break;
                }
            }

        }

        private static void PrintFirstNElements(int[] myArr, string[] comand)
        {
            int count = int.Parse(comand[1]);
            string type = comand[2];
            if (count > myArr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                switch (type)
                {
                    case "odd":
                        if (!myArr.Any(n => n % 2 == 1))
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (myArr.Where(n => n % 2 == 1).Count() < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 1).ToArray())}]");
                            }
                            else
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 1).ToArray().Take(count))}]");
                        }

                        break;
                    case "even":
                        if (!myArr.Any(n => n % 2 == 0))
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            if (myArr.Where(n => n % 2 == 0).Count() < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 0).ToArray())}]");
                            }
                            else
                                Console.WriteLine($"[{string.Join(", ", myArr.Where(n => n % 2 == 0).ToArray().Take(count))}]");
                        }


                        break;
                }
            }

        }

        private static void PrintMinIndex(int[] myArr, string[] comand)
        {
            string type = comand[1];
            bool noMatches = false;
            int minNum = int.MaxValue;
            switch (type)
            {
                case "odd":
                    if (myArr.Any(x => x % 2 == 1))
                    {
                        minNum = myArr.Where(x => x % 2 == 1).Min();
                    }
                    else
                    {
                        noMatches = true;
                    }

                    break;
                case "even":
                    if (myArr.Any(x => x % 2 == 0))
                    {
                        minNum = myArr.Where(x => x % 2 == 0).Min();
                    }
                    else
                    {
                        noMatches = true;
                    }

                    break;
            }
            if (noMatches)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(Array.FindLastIndex(myArr, n => n == minNum));
            }

        }

        private static void PrintMaxIndex(int[] myArr, string[] comand)
        {
            string type = comand[1];
            bool noMatches = false;
            int maxNum = int.MinValue;
            switch (type)
            {
                case "odd":
                    if (myArr.Any(x => x % 2 == 1))
                    {
                        maxNum = myArr.Where(x => x % 2 == 1).Max();
                    }
                    else
                    {
                        noMatches = true;
                    }

                    break;
                case "even":
                    if (myArr.Any(x => x % 2 == 0))
                    {
                        maxNum = myArr.Where(x => x % 2 == 0).Max();
                    }
                    else
                    {
                        noMatches = true;
                    }

                    break;
            }
            if (noMatches)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(Array.FindLastIndex(myArr, n => n == maxNum));
            }


        }

        private static int[] ExchangeArray(int[] myArr, string[] comand)
        {

            int index = int.Parse(comand[1]);
            int[] result = myArr;
            if (index < 0 || index >= myArr.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                result = myArr.Skip(index + 1).Concat(myArr.Take(index + 1)).ToArray();
            }

            return result;

        }
    }
}