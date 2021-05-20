using System;

namespace ConsoleApp7_4
{
    class Program
    {
        static string CheckSign(int Num)
        {
            string result = null;
            if (Num>0)
            {
                result = "Число положительное";
                
            }
            else
            {
                result = "Число отрицательное";
                
            }
            return result;
        }
        static string CheckSimple(int Num)
        {
            string result = null;
            if(Num%2 == 0 || Num % 3)
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Number = Int32.Parse(Console.ReadLine());

        }
    }
}
