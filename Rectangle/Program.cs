using System;

namespace Rectangle
{
    class Program
    {
        public static void Main()
        {
            int a = GetInt();
            int b = GetInt();

            PrintResult(GetS(a, b), GetP(a, b), GetD(a, b));
        }

        public static int GetInt()
        {
            Console.Write("Введите целое число = ");
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public static int GetS(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int GetP(int firstNumber, int secondNumber)
        {
            return 2 * (firstNumber + secondNumber);
        }

        public static double GetD(int firstNumber, int secondNumber)
        {
            return Math.Sqrt((firstNumber * firstNumber) 
                                 + (secondNumber * secondNumber));
        }

        public static void PrintResult(int S, int P, double d)
        {
            Console.WriteLine("S = " + S);
            Console.WriteLine("P = " + P);
            Console.WriteLine("d = " + d);
        }
    }
}