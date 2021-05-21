using System;

namespace ConsoleApp8_3
{
    class Program
    {
        static int Factorial(int Num)
        {
            if (Num == 0)
                return 1;
            else
                 return Num * Factorial(Num - 1);
        }
        static void Main(string[] args)
        {
            int Num = 0;
            Console.WriteLine("Введите количество клиентов: ");
            Num = Int32.Parse(Console.ReadLine());
            int result = Factorial(Num);
            Console.WriteLine("Количество вариантов перевозок: {0} ", result);
        }
    }
}
