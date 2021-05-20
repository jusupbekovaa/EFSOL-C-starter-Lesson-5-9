using System;

namespace ConsoleApp6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов: ");
            int customerCount = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            do
            {
                factorial *= customerCount--;
            }
            while (customerCount > 0);

            Console.WriteLine("Количество вариантов перевозок: {0}", factorial);
            Console.ReadKey();
        }
    }
}
