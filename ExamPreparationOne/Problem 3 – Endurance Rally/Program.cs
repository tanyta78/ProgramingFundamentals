namespace _03.Endurance_Rally
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            double[] trackzones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                double startFuel = currentName.First() - 'A' + 'A';
                double endFuel = startFuel;
                for (int j = 0; j < trackzones.Length; j++)
                {
                    if (checkpoints.Contains(j))
                    {
                        endFuel += trackzones[j];
                    }
                    else
                    {
                        endFuel -= trackzones[j];
                    }
                    if (endFuel <= 0)
                    {
                        Console.WriteLine($"{currentName} - reached {j}");
                        break;
                    }
                }
                if (endFuel > 0)
                {
                    Console.WriteLine($"{currentName} - fuel left {endFuel:f2}");
                }
            }
        }
    }
}
