using System;

namespace Exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            string expression;
            Console.WriteLine("Enter expression e.g (2 + 3)");
            expression = Console.ReadLine();

            string[] values = expression.Split(' ');

            if (values.Length != 3)
            {
                Console.WriteLine("Invalid input");
            }

            if (!double.TryParse(values[0], out n1) || !double.TryParse(values[2], out n2))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            char op = Convert.ToChar(values[1]);
            double result = 0;

            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    // Check for division by zero
                    if (n2 != 0)
                        result = n1 / n2;
                    else
                        Console.WriteLine("Error: Division by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid Operator!");
                    return; // Exit the program
            }
            Console.WriteLine($"Result: {n1} {op} {n2} = {result}");
            Console.ReadLine();
        }
    }
}
