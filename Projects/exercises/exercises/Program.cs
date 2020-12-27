using System;

namespace exercises
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Write an odd number: ");
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Not an odd number.");

            }

            else Console.WriteLine("It's an odd number!");

            return();
             */

            Console.WriteLine("Enter a value for a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine( (a*b)/(a+b));
           

        }
    }
}
