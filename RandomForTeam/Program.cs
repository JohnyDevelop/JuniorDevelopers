using System;

namespace RandomForTeam
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int from = 1;
            int to = 3;
            Random rand = new Random();
            Console.WriteLine(rand.Next(from, to));
        }
    }
}