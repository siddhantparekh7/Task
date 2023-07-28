using System;

namespace Task1
{
    class Tax
    {
        public static string employeeName;
        public static double commision;
        public static double federalTax;
        public static double retirementPlan;
        public static double socialSecurity;
        public static double sales;

        public static void calculate()
        {
            commision = sales * 0.07;
            federalTax = commision * .18;
            retirementPlan = commision * .1;
            socialSecurity = commision * .06;
            display();
        }
        public static void display()
        {
            Console.WriteLine("<-----------Employee Information----------->");
            Console.WriteLine($"Employee Name: {employeeName:f2}\nTotal Sales: ${sales:f2}\nCommision: ${commision:f2}\nFederal Tax: ${federalTax:f2}\nRetirement Plan: ${retirementPlan:f2}\nSocial Security:${socialSecurity:f2}");
            Console.ReadLine();
        }
        public static void Run()
        {
            Console.WriteLine("Enter Employee name");
            employeeName = Console.ReadLine();
            Console.WriteLine("Enter total sales");
            sales = double.Parse(Console.ReadLine());
            calculate();
        }
    }
}
