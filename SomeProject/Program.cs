using System;

namespace SomeProject
{
    class Program
    {
        public static void Main()
        {
            double firstNumber;
            double secondNumber;
            
            Console.Write("Первое число = ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Второе число = ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            string operation;
            Console.Write("Операция(+, -, *, /) = ");
            operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine(Sum(firstNumber, secondNumber));
            } 
            else if (operation == "-")
            {
                Console.WriteLine(Sub(firstNumber, secondNumber));
            } 
            else if (operation == "*")
            {
                Console.WriteLine(Mult(firstNumber, secondNumber));
            } 
            else if (operation == "/")
            {
                Console.WriteLine(Div(firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine("Не правильный оператор");
            }
        }

        public static double Sum(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public static double Sub(double a, double b)
        {
            double c = a - b;
            return c;
        }
       
        public static double Mult(double a, double b)
        {
            double c = a * b;
            return c;
        }
        
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Делить на ноль нельзя");
                return 0;
            }
            
            double c = a / b;
            return c;
        }
    }
}