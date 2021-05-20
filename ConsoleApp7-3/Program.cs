using System;

namespace ConsoleApp7_3
{
    class Program
    {
        static double ConvertingMoney (double money,double foreignMoney)
        {
            double result = money / foreignMoney;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в вашей валюте: ");
            double money = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите курс иностранной валюты: ");
            double foreignMoney = Int32.Parse(Console.ReadLine());
            double result = ConvertingMoney(money, foreignMoney);
            Console.WriteLine("Результат конвертирования: {0}", result);
            Console.ReadKey();

        }
    }
}
