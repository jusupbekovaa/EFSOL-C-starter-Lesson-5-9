using System;

namespace ConsoleApp9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            MyReverse(myArray);
            int[] resultArray = SubArray(myArray, 3, 6);
            for(int i=0; i< resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
        }

        static void MyReverse(int[] array)
        {
            Console.WriteLine("Инвертированный массив");
            for (int i = (array.Length-1);i>=0;i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        static int[] SubArray(int[]array, int index, int count)
        {
            Console.WriteLine("Новый массив с индекса {0}, количество элементов {1}", index, count);
            int[] resultArray = new int[count];
            for(int i= index; i<array.Length; i++)
            {
                resultArray[i] = array[i];
            }
            for(int i =0; i<resultArray.Length;i++)
            {
                if (resultArray[i] == 0)
                {
                    resultArray[i] = 1;
                }
                else
                    continue;
            }
            return resultArray;
        }
    }
}
