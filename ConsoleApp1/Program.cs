using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Number = Convert.ToInt32(Console.ReadLine());

            //if (Number % 2 == 0)
            //    Console.WriteLine("Число четное");
            //else
            //    Console.WriteLine("Число нечетное");

            if( (Number&1) == 0)
                Console.WriteLine("Число четное");
            else
               Console.WriteLine("Число нечетное");

        }
    }
}
