using System;

namespace ConsoleApp5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            double result1 = (x += y >> x++ * z);
            double result2 = (z = ++x & y * 5);
            double result3 = (y /= x + 5 | z);
            double result4 = (z = x++ & y * 5);
            double result5 = (x = y << x++ ^ z);
            Console.WriteLine("Первый результат: {0}", result1);
            Console.WriteLine("Второй результат: {0}", result2);
            Console.WriteLine("Третий результат: {0}", result3);
            Console.WriteLine("Четвертый результат: {0}", result4);
            Console.WriteLine("Пятый результат: {0}", result5);
            Console.ReadKey();
        }
    }
}
