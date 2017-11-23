namespace P02_GoingToParty
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var directions = Console.ReadLine().ToCharArray();
            var position = 0;

            while (true)
            {
                if (position < 0 || position >= directions.Length)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", position);
                    break;
                }

                var forCheck = directions[position];

                if (Char.IsLower(forCheck) && Char.IsLetter(forCheck))
                {
                    position += (int)forCheck - (int)'a' + 1;
                }
                else if (Char.IsUpper(forCheck) && Char.IsLetter(forCheck))
                {
                    position -= (int)forCheck - (int)'A' + 1;
                }else if (forCheck=='^')
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", position);
                    break;
                }
            }
        }
    }
}
