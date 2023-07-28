using System;

namespace Task1
{
    class Fine
    {
        public static double initialFine = 80;
        public static double extraFine = 87.5;
        public static int speedLimit;
        public static int recordedSpeed;
        public static double fine;
        public static double extraSpeeding;
        public static double segOf5Mph;
        public static void ExtraSpeeding()
        {
            extraSpeeding = recordedSpeed - speedLimit;
            segOf5Mph = Math.Floor(extraSpeeding / 5);
        }
        public static void SeniorFine()
        {
            ExtraSpeeding();
            fine = initialFine + (extraFine * segOf5Mph) + 50;
            if (extraSpeeding > 20)
            {
                fine += 150;
            }
            Console.WriteLine($"Fine : {fine}");
            Console.ReadLine();
        }

        public static void FreshMan()
        {
            ExtraSpeeding();
            fine = initialFine + (extraFine * segOf5Mph);
            if (extraSpeeding < 20)
            {
                Console.WriteLine($"Fine after deduction: {fine - 50}");
            }
            else
            {
                Console.WriteLine($"Fine : {fine + 100}");
            }
        }
        public static void Rest()
        {
            ExtraSpeeding();
            fine = initialFine + (extraFine * segOf5Mph);
            if (extraSpeeding >= 20)
            {
                Console.WriteLine($"Fine: {fine + 100}");
            }
            Console.WriteLine($"Fine: {fine}");
        }
        public static void Run()
        {
            int choice = 0;
            while (true)
            {
                Console.WriteLine("Enter Speed Limit");
                speedLimit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Recorded Speed");
                recordedSpeed = int.Parse(Console.ReadLine());
                if (speedLimit == 35 && recordedSpeed > 35|| speedLimit == 15 && recordedSpeed > 15)
                {
                    Console.WriteLine("Enter classification:\n1.Senior\n2.Freshmen\n3.Sophomore\n4.Junior");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            SeniorFine();
                            break;

                        case 2:
                            FreshMan();
                            break;

                        case 3:
                            Rest();
                            break;
                        case 4:
                            Rest();
                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Enter valid classification\n");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Enter valid speed limit or recorded speed limit");
                }
            }
        }
    }
}
