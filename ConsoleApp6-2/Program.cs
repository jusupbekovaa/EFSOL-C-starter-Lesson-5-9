using System;

namespace ConsoleApp6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            do
            {
                result += firstNumber;
                firstNumber++;
            }
            while (firstNumber <= secondNumber);
            Console.WriteLine("Результат: {0}", result);
            
        }
    }
}
