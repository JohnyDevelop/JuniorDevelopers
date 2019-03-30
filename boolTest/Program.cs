using System;

namespace boolTest
{
    class Program
    {
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool result = go(a, b);
            bool hto_to = GG(a, b);
            Console.WriteLine(result);
            Console.WriteLine(hto_to);
        }

        public static bool go(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public static bool GG(int a, int b)
        {
            if (b == a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}