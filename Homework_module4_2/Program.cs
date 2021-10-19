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
            double radius = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Circle area is {0}", result);
        }

        static void Square()
        {
            Console.WriteLine("2.1 Input should be side length");
            double length = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            result = Math.Pow(length, 2);
            Console.WriteLine("Square area is {0}", result);
        }
    }
}