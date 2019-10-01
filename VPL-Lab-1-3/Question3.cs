using System;

namespace VPL_Lab_1_3
{
    class Question3
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("Enter a Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", num3);
            }

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("The smallest number is: {0}", num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("The smallest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("The smallest number is: {0}", num3);
            }
            Console.ReadLine();
        }
    }
}
