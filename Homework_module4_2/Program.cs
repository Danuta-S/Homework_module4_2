using System;

namespace Module4_2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.ReadLine();
        }
        static void Intro()
        {
            Console.WriteLine(@"Options:
1. Calculate circle area

2. Calculate square area");

            string menuOption = Console.ReadLine();
            switch (menuOption)
            {
                case "1":
                    Circle();
                    break;

                case "2":
                    Square();
                    break;
                default:
                    Console.WriteLine("It is not a valid input!");
                    break;
            }
        }

        static void Circle()
        {
            Console.WriteLine($"1.1 Input should be radius");
            string r = Console.ReadLine();
            double radius = Convert.ToDouble(r);
            double result = Math.PI * Math.Pow(radius, 2);
            if (double.TryParse(r, out radius) && radius > 0)
            {
                Console.WriteLine("Circle area is {0}", result);
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
        }

        static void Square()
        {
            Console.WriteLine("2.1 Input should be side length");
            double length = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(length, 2);
            if (length > 0)
            {
                Console.WriteLine("Square area is {0}", result);
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
        }
    }
}