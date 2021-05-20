using System;

namespace ConsoleApp7_2
{
    class Program
    {
        static double OperationAdd(int firstNum, int secondNum)
        {
            double result = 0;
            result = firstNum + secondNum;
            return result;
        }
        static double OperationSub(int firstNum, int secondNum)
        {
            double result = 0;
            result = firstNum - secondNum;
            return result;
        }
        static double OperationMul(int firstNum, int secondNum)
        {
            double result = 0;
            result = firstNum * secondNum;
            return result;
        }
        static double OperationDiv(int firstNum, int secondNum)
        {
            double result = 0;
            if (secondNum != 0)
            {
                result = firstNum / secondNum;
                return result;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
                return result = 0;
            }

        }
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("Введите первое число: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию: ");
            string sign = Console.ReadLine();
            switch(sign)
            {
                case "+":
                    result = OperationAdd(firstNumber, secondNumber);
                    Console.WriteLine("Результат: {0} ", result);
                    break;
                case "-":
                    result = OperationSub(firstNumber, secondNumber);
                    Console.WriteLine("Результат: {0} ", result);
                    break;
                case "*":
                    result = OperationMul(firstNumber, secondNumber);
                    Console.WriteLine("Результат: {0} ", result);
                    break;
                case "/":
                    result = OperationDiv(firstNumber, secondNumber);
                    Console.WriteLine("Результат: {0} ", result);
                    break;
                default:
                    break;
            }
        }


    }
}
