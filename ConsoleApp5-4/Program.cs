using System;

namespace ConsoleApp5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double premia = 0;
            Console.WriteLine("Введите заработную плату");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите опыт работы(в годах)");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 5)
            {
                premia = salary * 0.1;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else if (year >= 5 && year < 10)
            {
                premia = salary * 0.15;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else if (year >= 10 && year < 15)
            {
                premia = salary * 0.25;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else if (year >= 15 && year < 20)
            {
                premia = salary * 0.35;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else if (year >= 20 && year < 25)
            {
                premia = salary * 0.45;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else if (year >= 25)
            {
                premia = salary * 0.5;
                Console.WriteLine("Заработная плата: {0} , Стаж работы: {1}, Премия: {2}", salary, year, premia);
            }
            else
                Console.WriteLine("Неправильно введенные данные");
            Console.ReadKey();
        }
    }
}
