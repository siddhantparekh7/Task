using System;

namespace Task1
{
    class Motorway
    {
        public string Name { get; set; }
        public string RoadType { get; set; }
        public char Direction { get; set; }
        public string Surface { get; set; }
        public int NoOfLanes { get; set; }
        public bool Toll { get; set; }
        public string MaintainParty { get; set; }

        public Motorway(string name, string type, char direction, string surface, int lane, bool toll, string party)
        {
            Name = name;
            RoadType = type;
            Direction = direction;
            Surface = surface;
            NoOfLanes = lane;
            Toll = toll;
            MaintainParty = party;
        }

        public string GetFullNameAndTollAndLane()
        {
            Console.WriteLine("------------------------------------");
            return $"{Name} Motorway - Toll: {(Toll ? "Yes" : "No")} - Number of Lanes are {NoOfLanes}";
        }

        public override string ToString()
        {
            return $"Name: {Name}\nRoad Type: {RoadType}\nDirection: {Direction}\nSurface: {Surface}\nNumber of Lanes: {NoOfLanes}\nToll: {(Toll ? "Yes" : "No")}\nMaintaining Party: {MaintainParty}";
        }

        public static void Run()
        {
            Console.WriteLine("Enter Following Details");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Road Type: Road, Street, Avenue,Lane");
            string type = Console.ReadLine();

            Console.WriteLine("Direction: E,W,N,S");
            char direction = char.Parse(Console.ReadLine());

            Console.WriteLine("Surface: Blacktop. Gravel, Sand, Concrete");
            string surface = Console.ReadLine();

            Console.WriteLine("Number of Lanes");
            int lane = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Is toll taken? True or False");
            bool toll = bool.Parse(Console.ReadLine());

            Console.WriteLine("Maintenence Party:");
            string party = Console.ReadLine();

            Motorway objMotorway = new Motorway(name, type, direction, surface, lane, toll, party);

            string GetFullNameAndTollAndLane = objMotorway.GetFullNameAndTollAndLane();
            Console.WriteLine(GetFullNameAndTollAndLane);

            string MotorInfo = objMotorway.ToString();
            Console.WriteLine("\nMotorway Information:");
            Console.WriteLine(MotorInfo);

        }
    }
}