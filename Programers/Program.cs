using System;

namespace Programers
{
    enum Level
    {
        Trainee,
        Junior,
        Middle,
        Senior
    }

    struct Programer
    {
        public string fio;
        public string date;
        public Level level;
        public string projectName;
    }
    
    class Program
    {
        public static void Main()
        {
            Programer[] array = new Programer[7];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetProgramerFormKeyboard();
            }
            
            Print("Input level = ", false);
            string stringLevel = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].level.ToString() == stringLevel)
                {
                    Print(array[i]);
                }
            }
        }

        public static Programer GetProgramerFormKeyboard()
        {
            Programer programer;
            Print("FIO = ", false);
            programer.fio = Console.ReadLine();
            Print("Born date = ", false);
            programer.date = Console.ReadLine();
            Print("Level = ", false);
            programer.level = GetLevelFromkeyboard();
            Print("Project name = ", false);
            programer.projectName = Console.ReadLine();

            return programer;
        }

        public static Level GetLevelFromkeyboard()
        {
            Level resultLevel = Level.Trainee;
            string level = Console.ReadLine();

            if (level == "Trainee")
                resultLevel = Level.Trainee;
            if (level == "Junior")
                resultLevel = Level.Junior;
            if (level == "Middle")
                resultLevel = Level.Middle;
            if (level == "Senior")
                resultLevel = Level.Senior;

            return resultLevel;
        }
        
        public static void Print(Programer programer)
        {
            Console.WriteLine("FIO = " + programer.fio);
            Console.WriteLine("Born date = " + programer.date);
            Console.WriteLine("Level = " + programer.level);
            Console.WriteLine("Project name = " + programer.projectName);
        }
        
        public static void Print(string value, bool newLine = true)
        {
            if (newLine)
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