namespace P03_SecretMessage
{
    using System;
    using System.Text;

    public class Program
    {
       public static void Main(string[] args)
       {
            int rowCount = 0;
            var result = new StringBuilder();

            while (true)
            {
                rowCount++;
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine(result.ToString());
                    break;
                }
                int start = int.Parse(input);
                int end = int.Parse(Console.ReadLine());
                string sequence = Console.ReadLine();
                int startIndex = GetIndex(start, sequence.Length);
                int endIndex = GetIndex(end, sequence.Length);

                int step = rowCount % 2 == 0 ? 4 : 3;
                for (int i = startIndex; i <= endIndex; i += step)
                {
                    result.Append(sequence[i]);
                }
            }
        }

        static int GetIndex(int index, int length)
        {
            if (index < 0)
            {
                index = length + index;
            }

            return index;
        }
    }
}
