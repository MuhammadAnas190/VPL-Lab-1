using System;

namespace VPL_Lab_1_4
{
    class Question4
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Enter month number: ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("Winter");
            }
            else if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Spring");
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Summer");
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Autumn");
            }
            else
            {
                Console.WriteLine("Err. invalid input");
            }

            Console.ReadLine();
        }
    }
}
