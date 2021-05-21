using System;

namespace ConsoleApp8_2
{
    class Program
    {
        static void CreditStatus(double paymentSum, double creditSum = 700, int MonthCount = 7)
        {
                while (creditSum > 0)
                {
                    Console.WriteLine("Введите суммy платежа: ");
                    paymentSum = Convert.ToDouble(Console.ReadLine());
                    if (paymentSum < creditSum)
                    {
                        creditSum -= paymentSum;
                        MonthCount--;
                        Console.WriteLine("Остаток долга: {0} Срок оплаты: {1}", creditSum, MonthCount);
                    }
                    else
                    {
                        paymentSum -= creditSum;
                        Console.WriteLine("Долг погашен. Сумма переплаты: {0}", paymentSum);
                         break;
                    }

                }
        }
            
        
        static void Main(string[] args)
        {
            double paymentSum = 0;
            CreditStatus(paymentSum);
        }
    }
}
