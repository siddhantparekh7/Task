using System;
using System.Collections;
using DataTablePrettyPrinter;
using System.Data;

namespace Task2
{
    class Hexadecimal
    {
        

        public static void Run()
        {
            DataTable table = new DataTable(null);
            try
            {
                string hexadecimal;
                var hexaArr = new ArrayList();
                var deciArr = new ArrayList();
                int deciSum = 0;

                //Input
                Console.WriteLine("Enter Hexadecimal value:");
                hexadecimal = Console.ReadLine();

                //Storing hexadecimal into Arraylist
                foreach (char inputHexa in hexadecimal)
                {
                    hexaArr.Add(inputHexa.ToString());
                }

                //Converting hexadecimal to decimal and storing it in Arraylist
                for (int i = 0; i < hexaArr.Count; i++)
                {
                    string decimalNum = (string)hexaArr[i];
                    int decimalValue = int.Parse(decimalNum, System.Globalization.NumberStyles.HexNumber);
                    deciArr.Add(decimalValue);
                }

                //Sum of Decimal
                foreach (int obj in deciArr)
                {
                    deciSum += obj;
                }

                //Table initialization
                table.Columns.Add("Sum", typeof(string));
                table.Columns.Add("Hexadecimal", typeof(string));
                table.Columns.Add("Decimal", typeof(Int32));
                table.Columns[0].SetShowColumnName(false);

                //Display ArrayList
                for(int i = 0;i < deciArr.Count; i++)
                {
                    table.Rows.Add(i+1,hexaArr[i], deciArr[i]);
                }
                table.Rows.Add("Sum", hexadecimal, deciSum);
                table.SetShowTableName(false);
                Console.WriteLine(table.ToPrettyPrintedString());

                
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
