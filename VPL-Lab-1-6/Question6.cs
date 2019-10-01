using System;

namespace VPL_Lab_1_6
{
    class Question6
    {
        static void Main(string[] args)
        {
            double num1, num2;
            double? final = null;
            String operand;
            Console.WriteLine("Enter a number");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operand");
            operand = Console.ReadLine();

            operand = operand.ToLower();
            if (operand == "add" || operand == "plus" || operand == "+")
            {
                final = num1 + num2;
            }
            else if (operand == "subtract" || operand == "minus" || operand == "-")
            {
                final = num1 - num2;
            }
            else if (operand == "product" || operand == "multiply" || operand == "*")
            {
                final = num1 * num2;
            }
            else if (operand == "separate" || operand == "division" || operand == "/")
            {
                final = num1 / num2;
            }

            Console.Write("Your Final answer is: \t");
            Console.WriteLine(final == null ? 0 : final);
            Console.ReadLine();
        }
    }
}
