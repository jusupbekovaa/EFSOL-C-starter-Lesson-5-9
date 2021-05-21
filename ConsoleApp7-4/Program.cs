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
            string result = "Не входит в диапазон простых или непростых чисел";
            if (Num > 0)
            {
                result = "Число простое";
                for (int i = 2; i < (Num / 2); i++)
                {
                    if (Num % i == 0)
                    {
                        result = "Число непростое";
                        break;
                    }
                }
            }
            return result;
        }
        static void CheckDiv(int Num)
        {
           
            for(int i=3; i<=9; i+=3)
            {
                if(Num%i==0)
                {
                    Console.WriteLine( "Число " + Num + " Делится без остатка на " + i) ;
                }
            }
            for(int i=2; i<=5;i+=3)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine("Число " + Num + " Делится без остатка на " + i);
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Number = Int32.Parse(Console.ReadLine());
            string CheckSignResult = CheckSign(Number);
            string CheckSimpleResult = CheckSimple(Number);
            CheckDiv(Number);
            Console.WriteLine("{0}, {1} ", CheckSignResult, CheckSimpleResult);
        }
    }
}
