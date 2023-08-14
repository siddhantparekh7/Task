using System;

namespace Exp2
{
    class StructEnum
    {
        public enum RectangleType
        {
            Regular,
            Square
        }

        public struct Rectangle
        {
            public int Width, Height;
            public RectangleType Type; // Adding the RectangleType field
        }

        public static void Run()
        {
            Rectangle regularRect = new Rectangle();
            regularRect.Width = 5;
            regularRect.Height = 10;
            regularRect.Type = RectangleType.Regular;

            Rectangle squareRect = new Rectangle();
            squareRect.Width = 7;
            squareRect.Height = 7;
            squareRect.Type = RectangleType.Square;

            Console.WriteLine("Area of Regular Rectangle: " + (regularRect.Width * regularRect.Height));
            Console.WriteLine("Area of Square Rectangle: " + (squareRect.Width * squareRect.Height));
            Console.ReadLine();
        }
    }
}
