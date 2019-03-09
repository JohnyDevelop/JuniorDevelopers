using System;

namespace ScanArray
{
    class Program
    {
        public static void Main()
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0;i < 10; i++)
            {
                array[i] = rand.Next(1, 100);
            }

            bool TrueFalse = false;
            for (int i = 0; i < 10; i = i + 1)
            {
                Console.WriteLine(array[i]);
                if (array[i] == 50)
                {
                    TrueFalse = true;
                }
            }
            Console.WriteLine(TrueFalse);
            
        }
    }
}