using System;
using System.Net;
using System.Runtime.InteropServices;

namespace OutSort
{
    //№1 Дима
    //Ввод размера N массива с клавиатуры
    //Создание массива из N элементов
    //Заполнение массива случайными числами
    
    //№2 Арик
    //Вывод массива до сортировки
    //Сортировка массива по убыванию
    //Вывод массива после сортировки
    
    //№3 Ксюша
    //Вывод всех четных элементов массива
    
    //№4 Егор
    //Вывод всех нечетных элементов массива
    
    //№5 Паша
    //Вывод массива после сортировки наоборот
    class Program
    {
        public static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[N];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }

            Print(array, " ");
            Console.WriteLine();
            Sort(ref array, ref N);
            Print(array, " ");

            for (int i = 0; i < N; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }
            }

            for (int i = 0; i > N; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }


        public static void Print(int[] array, string a = "")
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
        }

        public static void Sort(ref int[] array,ref int N)
        {
            for (int i = 0;i < N;i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
}