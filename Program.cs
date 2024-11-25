using System.ComponentModel;
using System.Net;
using System.Reflection.Metadata;

namespace Kalkulatoroppgave;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

    while (true)
    {
        Console.WriteLine("Do you want to add, subtract, multiply or divide numbers? (type 'exit' to exit)");
        string addorsubtract = Console.ReadLine().ToLower();

        if (addorsubtract == "exit")
        {
            Console.WriteLine("Goodbye. Have a nice day!");
            break;
        }

        if (addorsubtract == "add")
        {
            Console.WriteLine("What is the first number you would like to add?");
            string? a = Console.ReadLine();
            if (a == null || a == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }

            Console.WriteLine("What is the second number you would like to add?");
            string? b = Console.ReadLine();
            if (b == null || b == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }
    
            double A = double.Parse(a);
            double B = double.Parse(b);

            Console.WriteLine($"Your numbers {A} and {B} added together are: " + calculator.Add(A, B));
        } else if (addorsubtract == "subtract")
        {
            Console.WriteLine("What is the first number you would like to subtract from?");
            string? a = Console.ReadLine();
            if (a == null || a == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }
            Console.WriteLine("What is the second number you would like to subtract?");
            string? b = Console.ReadLine();
            if (b == null || b == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }

            double A = double.Parse(a);
            double B = double.Parse(b);

            Console.WriteLine($"Your numbers {A} and {B} subtracted from eachother is: " + calculator.Subtract(A, B));
        } else if (addorsubtract == "multiply")
        {
            Console.WriteLine("What is the first number you would like to multiply?");
            string? a = Console.ReadLine();
            if (a == null || a == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }
            Console.WriteLine("What is the second number you would like to multiply?");
            string? b = Console.ReadLine();
            if (b == null || b == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }

            double A = double.Parse(a);
            double B = double.Parse(b);

            Console.WriteLine($"Your numbers {A} and {B} multiplied together is: " + calculator.Multiply(A, B));
        }else if (addorsubtract == "divide")
        {
            Console.WriteLine("What is the first number you would like to divide from?");
            string? a = Console.ReadLine();
            if (a == null || a == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }
            Console.WriteLine("What is the second number you would like to divide with?");
            string? b = Console.ReadLine();
            if (b == null || b == string.Empty)
            {
                Console.WriteLine("Please write a number and start again!");
                continue;
            }

            double A = double.Parse(a);
            double B = double.Parse(b);

            Console.WriteLine($"Your numbers {A} and {B} divided are: " + calculator.Divide(A, B));
        } else
        {
            Console.WriteLine("Please write either 'add', 'subtract', 'multiply', 'divide' or 'exit'.");
        }
    }     
    }
}
