using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("\nSelect which task you want to perform:\n1.Motorway\n2.Miles\n3.Kilometer\n4.Tax\n5.Weight\n6.Fine");
                int choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Task1.Motorway.Run();
                        break;
                    case 2:
                        Task1.Miles.Run();
                        break; 
                    case 3:
                        Task1.Kilometer.Run();
                        break; 
                    case 4:
                        Task1.Tax.Run();
                        break;
                    case 5:
                        Task1.Weight.Run();
                        break;
                    case 6:
                        Task1.Fine.Run();
                        break;
                    default:
                        Console.WriteLine("Enter valid input");
                        break;
            }
                
            }
            
        }
    }
}
