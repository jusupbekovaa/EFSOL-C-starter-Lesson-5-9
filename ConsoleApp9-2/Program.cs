using System;
using System.Linq;

namespace ConsoleApp9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите количество элементов массива: ");
            int Num = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[Num];
            for(int i=0;i<Num;i++)
            {
                myArray[i] = random.Next(1, 20);
                Console.WriteLine("Элемент {0} индекса = {1}", i, myArray[i]);
            }
            int sum = 0;
            int average = 0;
            for(int i=0; i<myArray.Length; i++)
            {
                sum += myArray[i];
            }
            Console.WriteLine("Сумма элементов массива: {0}", sum);
            average = sum / (myArray.Length);
            Console.WriteLine("Средняя арифметическая элементов массива: {0}", average);
            Console.WriteLine("Нечетные элементы массива: ");
            for(int i=0; i<myArray.Length; i++)
            {
                
                if(myArray[i]%2 != 0)
                {
                    Console.WriteLine("Элемент {0} индекса = {1}",i,myArray[i]);
                }
            }

            int max = myArray[0];         
            for (int i = 0; i < myArray.Count(); i++) 
            {
                if (max < myArray[i])   
                {
                    max = myArray[i];  
                }
            }
            Console.WriteLine("Максимальный элемент массива: {0}", max);

            int min = myArray[0];        
            for (int i = 0; i < myArray.Count(); i++) 
            {
                if (min > myArray[i])    
                {
                    min = myArray[i];  
                }
            }
            Console.WriteLine("Минимальный элемент массива: {0}", min);

            int MinValue = myArray.Min();
            int MaxValue = myArray.Max();
            Console.WriteLine("Минимальный элемент массива: {0}, Максимальный элемент массива: {1}", MinValue, MaxValue);
        }
    }
}
