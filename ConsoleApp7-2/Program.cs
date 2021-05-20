using System;

namespace ConsoleApp7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию: ");
            string sign = Console.ReadLine();
            switch(sign)
            {
                case "+":

                    break;
                case "-":

                    break;
                case "*":

                    break;
                case "/":

                    break;
                default:
                    break;
            }
        }

        double OperationAdd(int firstNum, int secondNum)
        {
            double result = 0;
            result = firstNum + secondNum;
            return result;
        }
    }
}
