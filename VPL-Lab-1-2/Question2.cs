using System;

namespace VPL_Lab_1_2
{
    class Question2
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Enter a Number");
            num = Double.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
            Console.ReadLine();
        }
    }
}
