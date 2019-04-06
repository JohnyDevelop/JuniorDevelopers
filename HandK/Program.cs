using System;

namespace HandK
{
    class Program
    {
        public static void Main()
        {
            double grn = GetGrn();
            PrintResult(grn, GetUsd(grn),GetEuro(grn),GetRub(grn));

        }

        public static double GetGrn()
        {
            Console.Write("Введите количество гривен = ");
            double grn = Convert.ToDouble(Console.ReadLine());
            if (grn < 0)
            {
                grn = grn * -1;
            }
            return grn;
        }

        public static double GetUsd(double grn)
        {
            return grn / 27;
        }

        public static double GetEuro(double grn)
        {
            return grn / 31;
        }

        public static double GetRub(double grn)
        {
            return grn / 0.40;
        }

        public static void PrintResult(double grn, double usd, double euro, double rub)
        {
            Console.WriteLine(grn + " гривен = " + usd + " доларов" );
            Console.WriteLine(grn + " гривен = " + euro + " евро");
            Console.WriteLine(grn + " гривен = " + rub + " рублей");
        }
        
    }
}