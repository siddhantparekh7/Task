using System;

namespace Task1
{
    class Kilometer
    {
        public static double Miles;
        public static double Km;

        public static int choice;
        public static void MilesToKilometer(out double Km)
        {
            Km = Miles * 1.60934;
        }

        public static void KmToMiles(out double Miles)
        {
            Miles = Km * 0.621371192;
        }

        public static void Run()
        {

            Console.WriteLine("1 Mile = 1.60934 Kilometers");
            Console.WriteLine("1 Km = 0.621371192 Mile");

            while (true)
            {
                Console.WriteLine("\nEnter\n1.Miles to Km\n2.Km to Miles");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter miles");
                        Miles = double.Parse(Console.ReadLine());
                        Kilometer.MilesToKilometer(out Km);
                        Console.WriteLine($"{Miles} miles = {Km} Km");
                        break;

                    case 2:
                        Console.WriteLine("Enter kilometer");
                        Km = double.Parse(Console.ReadLine());
                        Kilometer.KmToMiles(out Miles);
                        Console.WriteLine($"{Km} Km = {Miles} miles");
                        break;
                    default:
                        Console.WriteLine("Thank you");
                        break;

                }
            }
        }
    }
}