using System;

namespace ConsoleApp6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle();
            RightTriangle();
            Rhombus();
            EquailateralTriangle();
        }


        static void Rectangle()
        {
            //Прямоугольник
            for (int count = 0; count < 5; count++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
            for (int count = 0; count < 2; count++)
            {

                Console.Write("*");
                for (int count2 = 0; count2 < 3; count2++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int count = 0; count < 5; count++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        static void RightTriangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.Write("\n");
        }

        static void EquailateralTriangle()
        {
            Console.Write("   *   ");
            Console.Write("\n");
            for (int count = 0; count < 3; count++)
            {
                if (count == 0)
                {
                    Console.Write("  ***  ");
                    Console.Write("\n");
                }
                else if (count == 1)
                {
                    Console.Write(" ***** ");
                    Console.Write("\n");
                }
                else if (count == 2)
                {
                    Console.Write("*******");
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }
        static void Rhombus()
        {
            Console.Write("  *  ");
            Console.Write("\n");
            for (int count = 0; count < 3; count++)
            {
                if (count == 0)
                {
                    Console.Write(" *** ");
                    Console.Write("\n");
                }
                else if (count == 1)
                {
                    Console.Write("*****");
                    Console.Write("\n");
                }
                else if (count == 2)
                {
                    Console.Write(" *** ");
                    Console.Write("\n");
                }
            }
            Console.Write("  *  ");
            Console.Write("\n");
        }
    }
}


