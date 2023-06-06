using System;

class Program
{
    public static string Indent(int count)
    {
        return "".PadLeft(count);
    }
    static void Main(string[] args)
    {
        Console.Clear();
        int option = 0;
        while (option != 4)
        {   
            Console.WriteLine("Menu Options:");
            Console.WriteLine(Indent(4) + "1. Start breathing activity");
            Console.WriteLine(Indent(4) + "2. Start reflecting activity");
            Console.WriteLine(Indent(4) + "3. Start listing activity");
            Console.WriteLine(Indent(4) + "4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Clear();
                    BreathingActivity brAct = new BreathingActivity();
                    brAct.DisplayStartMsg();
                    brAct.RenderActivity();
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Hola");
                    break;
                case 3:
                    Console.WriteLine("Hola");
                    break;
            }
        }
    }
}