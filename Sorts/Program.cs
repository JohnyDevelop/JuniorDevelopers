using System;
using System.Security;

namespace Sorts
{
    class Program
    {
        public static void Main()
        {
            int[] array = GetRandomArray(10);
            
            Print(array, "Массив до сортировки\n");
            Sort(ref array);
            Print(array, "Массив после сортировки\n");
        }

        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void Sort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j+1]);
                    }
                }   
            }
        }

        public static void Print(int[] array, string value = "")
        {
            if (value != string.Empty)
            {
                Console.Write(value);
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] GetRandomArray(int number)
        {
            Random random = new Random();
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            return array;
        }
    }
}