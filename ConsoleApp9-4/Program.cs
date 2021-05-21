using System;

namespace ConsoleApp9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Увеличенный массив: ");
            int[] resultArray = IncreaseArray(myArray);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
            Console.WriteLine("Измененный массив: ");
            int[] secondResultArray = ChangeArray(myArray, 5);
            for (int i =0; i < secondResultArray.Length; i++)
            {
                Console.WriteLine(secondResultArray[i]);
            }
        }
        static int[] IncreaseArray(int[]array)
        {
            int[] resultArray = new int[array.Length + 1];
            for(int i=0; i<array.Length;i++)
            {
                resultArray[i] = array[i];
            }
            return resultArray;
        }

        static int[] ChangeArray(int[]array, int value)
        {
            int[] resultArray = new int[array.Length+1];
            for(int i=1; i< resultArray.Length; i++)
            {
                resultArray[i] = array[i-1];
            }
            resultArray[0] = value;
            return resultArray;
        }
    }
}
