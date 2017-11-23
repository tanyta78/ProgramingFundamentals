namespace P02_Cards
{
    using System;

    public class Program
    {
        public static bool IsBitSet(ulong b, int pos)
        {
            return (b & ((ulong)1 << pos)) != 0;
        }
        static void Main(string[] args)
        {
            string[] cards =
            { "2c",  "3c",  "4c",  "5c",  "6c",  "7c",  "8c",  "9c", "Tc",  "Jc", "Qc",  "Kc", "Ac",

                "2d",  "3d",  "4d",  "5d",  "6d",  "7d",  "8d",  "9d",  "Td", "Jd",  "Qd", "Kd",  "Ad",

                "2h",  "3h",  "4h",  "5h",  "6h",  "7h",  "8h",  "9h", "Th",  "Jh", "Qh",  "Kh", "Ah",

                "2s",  "3s",  "4s",  "5s",  "6s",  "7s",  "8s",  "9s", "Ts",  "Js", "Qs",  "Ks", "As"};
            ulong max = ulong.MaxValue >> 12;
            int lines = int.Parse(Console.ReadLine());
            ulong result = 0;
            ulong occur = 0;
            for (int i = 0; i < lines; i++)
            {
                ulong current = ulong.Parse(Console.ReadLine());
                result = result | current;
                occur = occur ^ current;
            }
            if (result == max)
                Console.WriteLine("Full deck");
            else
                Console.WriteLine("Wa wa!");
            for (int i = 0; i < cards.Length - 1; i++)
            {
                if (IsBitSet(occur, i))
                    Console.Write(cards[i] + " ");
            }
            if (IsBitSet(occur, 51))
                Console.WriteLine(cards[51]);
            else Console.WriteLine();
        }
    }
}
