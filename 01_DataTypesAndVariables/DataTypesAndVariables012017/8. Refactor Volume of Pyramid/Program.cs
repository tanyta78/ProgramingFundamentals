namespace _8.Refactor_Volume_of_Pyramid
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double height = double.Parse(Console.ReadLine());
            double pyramidVolume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
        }
    }
}
