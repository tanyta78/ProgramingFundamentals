namespace _3.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Sum_Adjacent_Equal_Numbers
    {
        static void Main()
        {
            List<double> inputLine = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
          
            for (int i = 0; i < inputLine.Count-1; i++)
            {
                while (i < inputLine.Count-1)
                {
                    if (inputLine[i] == inputLine[i + 1])
                    {
                        inputLine[i ] = inputLine[i] + inputLine[i + 1];
                        inputLine.Remove(inputLine[i+1]);
                        if (i  > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
