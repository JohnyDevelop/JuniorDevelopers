using System;

namespace RandomFloatNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            double[] mass = new double[20];

            //дробные числа от 1 до 10
            int from = 1;
            int to = 10;

            for (int i = 0; i < mass.Length; i++)
            {
                int wholePart;
                int fractionPart;

                wholePart = rand.Next(from, to);
                fractionPart = rand.Next(0, 99);

                double newNumber = wholePart;
                newNumber = newNumber + (fractionPart / 100.0);

                mass[i] = newNumber;
                
                Console.WriteLine("New number = " + mass[i]);
            }
        }
    }
}