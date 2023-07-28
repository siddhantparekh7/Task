using System;

namespace Task1
{
    class Miles
    {
        public static double Mile;
        public static void MilesToFeetAndInch(out double feet, out double inch)
        {
            feet = Mile * 5280;
            inch = feet * 12;

        }

        public static void Run()
        {
            double feet;
            double inch;
            Console.WriteLine("Enter miles");
            Mile = double.Parse(Console.ReadLine());
            Miles.MilesToFeetAndInch(out feet, out inch);
            Console.WriteLine($"{Mile:F2} miles = {feet:F0} feet");
            Console.WriteLine($"{Mile:F2} miles = {inch:F0} inches");
        }
    }
}