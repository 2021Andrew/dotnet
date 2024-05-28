using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.WriteLine("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter symbol (/ * + -):");
                string symbol = Console.ReadLine();
                
                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition: " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction: " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication: " + res);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            res = num1 / num2;
                            Console.WriteLine("Division: " + res);
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid symbol.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                value = Console.ReadLine();

            } while (value.ToLower() == "yes");
        }
    }
}
