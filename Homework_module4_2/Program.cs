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

            string menu = Console.ReadLine();
            switch (menu)
            {
                #region circle
                case "1":
                case "1.":
                    Console.WriteLine($"1.1 Input should be radius");
                    string R = Console.ReadLine();
                    double radius = 0;
                    if (double.TryParse(R, out radius) && (radius > 0))
                    {
                        Console.WriteLine($"Circle area is " + CircleArea(radius));
                    }
                    else
                    {
                        Console.WriteLine("It is not a valid input!");
                    }
                    break;
                #endregion

                #region square
                case "2":
                case "2.":
                    Console.WriteLine($"2.1 Input should be side length");
                    string length = Console.ReadLine();
                    double sideLength = 0;
                    if (double.TryParse(length, out sideLength) && (sideLength > 0))
                    {
                        Console.WriteLine($"Square area is " + SquareArea(sideLength));
                    }
                    else
                    {
                        Console.WriteLine("It is not a valid input!");
                    }
                    break;
                default:
                    Console.WriteLine("It is not a valid input!");
                    break;
                    #endregion
            }
        }

        static double CircleArea(double number)
        {
            return Math.PI * Math.Pow(number, 2);
        }

        static double SquareArea(double number)
        {
            return Math.Pow(number, 2);
        }
    }
}