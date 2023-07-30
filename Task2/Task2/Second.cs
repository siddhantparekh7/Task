using System;
using System.Data;
using DataTablePrettyPrinter;

namespace Task2
{
    class Second
    {
        public static int totalseconds;
        
        public static void Calculation(int seconds, out int hours,out int minutes, out int remaining_sec)
        {
            //1hr = 3600 seconds
            //1min = 60 seconds
            hours = seconds / 3600;
            minutes = (seconds % 3600)/60;
            remaining_sec = seconds % 60;
        }
        public static void Run()
        {
            int hours,minutes,remainingsec;

            Console.WriteLine("Enter seconds:");
            totalseconds = int.Parse(Console.ReadLine());
            DataTable table = new DataTable($"Total Seconds = {totalseconds}");
            Console.WriteLine($"Seconds = {totalseconds}");
            Calculation(totalseconds,out hours,out minutes,out remainingsec);

            table.Columns.Add("Hours");
            table.Columns.Add("Minutes");
            table.Columns.Add("Seconds");

            table.Rows.Add(hours,minutes,remainingsec);
            Console.WriteLine(table.ToPrettyPrintedString());
        }
    }
}
