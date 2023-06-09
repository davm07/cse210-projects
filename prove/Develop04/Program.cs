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
        while (option != 5)
        {   
            Console.WriteLine("Menu Options:");
            Console.WriteLine(Indent(4) + "1. Start breathing activity");
            Console.WriteLine(Indent(4) + "2. Start reflecting activity");
            Console.WriteLine(Indent(4) + "3. Start listing activity");
            Console.WriteLine(Indent(4) + "4. Start gratitude activity");
            Console.WriteLine(Indent(4) + "5. Quit");
            Console.Write("Select a choice from the menu: ");
            try
            {
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        BreathingActivity brAct = new BreathingActivity();
                        brAct.DisplayStartMsg();
                        brAct.RenderActivity();
                        brAct.DisplayEndMsg();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        ReflectionActivity refAct = new ReflectionActivity();
                        refAct.DisplayStartMsg();
                        refAct.RenderActivity();
                        refAct.DisplayEndMsg();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity listAct = new ListingActivity();
                        listAct.DisplayStartMsg();
                        listAct.RenderActivity();
                        listAct.DisplayEndMsg();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        GratitudeActivity gratAct = new GratitudeActivity();
                        gratAct.DisplayStartMsg();
                        gratAct.RenderActivity();
                        gratAct.DisplayEndMsg();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("See you next time!");
                        break;
                    default:
                        Console.WriteLine("Please type a option from the menu!");
                        Console.WriteLine();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a valid number");
                Console.WriteLine();
            }
            
        }
    }
}