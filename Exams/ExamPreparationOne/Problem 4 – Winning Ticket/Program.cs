namespace Problem_4___Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    

    class Program
    {
        static void Main(string[] args)
        {
            //You are given a collection of tickets separated by commas and spaces. 
            char[] separators = new char[] { ',', ' ' };
            string[] tickets = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i].Trim();
                if (currentTicket.Length == 20)
                {
                    // CheckTicket(currentTicket);
                    List<char> winningSymbols = new List<char> { '@', '#', '$', '^' };
                    List<int> leftSideCheck = CheckTicket(currentTicket, winningSymbols, 0, 10);
                    List<int> rightSideCheck = CheckTicket(currentTicket, winningSymbols, 10, 20);

                    if (leftSideCheck[0] >= 6 && rightSideCheck[0] >= 6 && leftSideCheck[1] == rightSideCheck[1])
                    {
                        int minwinseq = Math.Min(leftSideCheck[0], rightSideCheck[0]);
                        if (minwinseq >= 6 && minwinseq <= 9)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {minwinseq}{winningSymbols[leftSideCheck[1]]}");
                        }
                        else if (minwinseq == 10)
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - {leftSideCheck[0]}{winningSymbols[leftSideCheck[1]]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }
        }

        private static List<int> CheckTicket(string currentTicket, List<char> winningSymbols, int startIndex, int endIndex)
        {
            int winninSymbolsequence = 0;
            int winningIndex = -1;
            int maxSequence = winninSymbolsequence;
            int maxseqind = winningIndex;
            for (int j = startIndex; j < endIndex; j++)
            {
                if (winningSymbols.Contains(currentTicket[j]))
                {
                    if (winningIndex < 0)
                    {
                        winninSymbolsequence = 1;
                        winningIndex = winningSymbols.IndexOf(currentTicket[j]);
                    }
                    else
                    {
                        if (winningIndex == winningSymbols.IndexOf(currentTicket[j]))
                        {
                            winninSymbolsequence++;
                        }
                        else
                        {
                            winningIndex = winningSymbols.IndexOf(currentTicket[j]);
                            winninSymbolsequence = 0;
                        }
                        if (winninSymbolsequence >= 6)
                        {
                            maxSequence = winninSymbolsequence;
                            maxseqind = winningIndex;
                        }
                    }
                }
                else
                {
                    if (winninSymbolsequence >= 6)
                    {
                        maxSequence = winninSymbolsequence;
                        maxseqind = winningIndex;
                    }
                    winninSymbolsequence = 0;
                    winningIndex = -1;
                }
            }
            List<int> result = new List<int> { maxSequence, maxseqind };
            return result;

        }

    }
}