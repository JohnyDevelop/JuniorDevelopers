using System;

namespace NewStructProject
{
    enum Genre
    {
        Fantasy,
        History,
        Horror
    }

    struct Film
    {
        public string Name;
        public Genre Genre;
    }
    class Program
    {
        public static void Main()
        {
            
        }

        public static Film GetfilmFromKeyboard()
        {

            Film film = new Film();
            Print("Name Film = " , false);
            film.Name = Console.ReadLine();
            Print("Genre Film" , false);

            return film;
        }

        public static void Print(Film film)
        {
            Console.WriteLine("Film Name" + film.Name);
            Console.WriteLine("Film Name" + film.Genre);
        }

        public static void Print(string value , bool NewLine = true)
        {
            if (NewLine)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
        }
    }
}
