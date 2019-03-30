using System;
using System.Runtime.InteropServices;

namespace SumOfMass
{
    internal class Program
    {
        public static void Main()
        {
            int[] array=new int[10];
            Random rand=new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(1,100);
                Console.WriteLine(array[i]);
            }

            int result = SumOfArray(array);

            Console.WriteLine(result);
        }

        public static int SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return sum;
        }
    }
}