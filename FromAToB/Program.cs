using System;

namespace FromAToB
{
    /*
     * a, b - input data value
     * composition form a to b
     * and result we must show on the display
     **/
    class Application
    {
        public static void Main()
        {
            Console.Write("a = ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b = ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int resultOfComposition = 1;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                resultOfComposition = resultOfComposition * i;
            }
            
            Console.WriteLine(
                "Result of composition form " + 
                firstNumber + " to " + secondNumber + 
                " = " + resultOfComposition);
        }
    }
}