namespace P03_HiddenMessage
{
    using System.Text;
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            while (input != "end")
            {
                var startIndex = int.Parse(input);
                var skipSymbolsNumber = int.Parse(Console.ReadLine());
                var message = Console.ReadLine().ToCharArray();

                if (startIndex < 0 && skipSymbolsNumber >= 0)
                {
                    while (startIndex < 0)
                    {
                        sb.Append(message[message.Length + startIndex]);
                        startIndex += skipSymbolsNumber;
                    }
                }
                else if (startIndex < 0 && skipSymbolsNumber < 0)
                {
                    while (message.Length + startIndex >= 0)
                    {
                        sb.Append(message[message.Length + startIndex]);
                        startIndex += skipSymbolsNumber;
                    }
                }
                else if (startIndex >= 0 && skipSymbolsNumber > 0)
                {
                    while (startIndex < message.Length)
                    {
                        sb.Append(message[startIndex]);
                        startIndex += skipSymbolsNumber;
                    }
                }
                else
                {
                    while (startIndex >= 0)
                    {
                        sb.Append(message[startIndex]);
                        startIndex += skipSymbolsNumber;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
