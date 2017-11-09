namespace _6.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            // Write a program to read two rectangles { left, top, width, height}
            // and print whether the first is inside the second.
            // The input is given as two lines, each holding a rectangle, described by 4 integers: left, top, width and height.
            Rectangle first = ReadRectangle();
            Rectangle second = ReadRectangle();
            IsInside(first, second);

        }

        private static void IsInside(Rectangle first, Rectangle second)
        {

            if (first.Left >= second.Left && first.Right <= second.Right && first.Top <= second.Top && first.Bottom >= second.Bottom)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            };
            
        }

        private static Rectangle ReadRectangle()
        {
            Rectangle currentRectangle = new Rectangle();
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            currentRectangle.Left = input[0];
            currentRectangle.Top = input[1];
            currentRectangle.Width = input[2];
            currentRectangle.Height = input[3];
            return currentRectangle;
        }

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public class Rectangle
        {
            public double Left { get; set; }
            public double Top { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public double Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public double Bottom
            {
                get
                {
                    return Top - Height;
                }
            }
        }


    }
}
