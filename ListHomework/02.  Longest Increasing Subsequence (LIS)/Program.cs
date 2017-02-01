﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Longest_Increasing_Subsequence__LIS_
{
    //Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost.
    class LongestIncreasingSubsequence
    {
        const int NO_PREVIOUS = -1;

        static void Main()
        {
            int[] seq = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray(); ;
            int[] len = new int[seq.Length];
            int[] prev = new int[seq.Length];

            int bestIndex = CalculateLongestIncreasingSubsequence(seq, len, prev);

            PrintLongestIncreasingSubsequence(seq, prev, bestIndex);
        }

        private static int CalculateLongestIncreasingSubsequence(int[] seq, int[] len, int[] prev)
        {
            int bestLen = 0;
            int bestIndex = 0;
            for (int x = 0; x < seq.Length; x++)
            {
                len[x] = 1;
                prev[x] = NO_PREVIOUS;
                for (int i = 0; i <= x - 1; i++)
                {
                    if (seq[i] < seq[x] && 1 + len[i] > len[x])
                    {
                        len[x] = 1 + len[i];
                        prev[x] = i;
                        if (len[x] > bestLen)
                        {
                            bestLen = len[x];
                            bestIndex = x;
                        }
                    }
                }
            }
            return bestIndex;
        }

        static void PrintLongestIncreasingSubsequence(int[] seq, int[] prev, int index)
        {
            List<int> numbers = new List<int>();
            while (index != NO_PREVIOUS)
            {
                numbers.Add(seq[index]);
                index = prev[index];
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
