using System;

namespace JulyTemperature
{
    /*
     * У нас есть массив дней Июля
     * Каждый елемент массива температура в этот день
     * Посчитать среднюю температуру за месяц
     **/
    class Program
    {
        public static void Main(string[] args)
        {
            const int numberOfDays = 31;
            int[] daysTemperature = new int[numberOfDays];
            
            Random rand = new Random();
            
            //Заполнение елементов случайно температурой
            for (int i = 0; i < numberOfDays; i++)
            {
                daysTemperature[i] = rand.Next(15, 35);
                Console.WriteLine(
                    i+1 + " число = " + 
                    daysTemperature[i] + " градусов Цельсия");
            }
            
            //Сумма градусов за месяц
            int sumOfTemperature = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                sumOfTemperature = sumOfTemperature + daysTemperature[i];
            }

            float monthlyAverageTemperature = (float) sumOfTemperature / 31;
            Console.WriteLine("Средняя температура за месяц = " + 
                              monthlyAverageTemperature + " градусов Цельсия");
        }
    }
}