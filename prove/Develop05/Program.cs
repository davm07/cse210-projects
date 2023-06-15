using System;

class Program
{
    public static string Indent(int count)
    {
        return "".PadLeft(count);
    }
    static void Main(string[] args)
    {
        int option = 0;
        while (option != 6)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(Indent(4) + "1. Create New Goal");
            Console.WriteLine(Indent(4) + "2. List Goals");
            Console.WriteLine(Indent(4) + "3. Save Goals");
            Console.WriteLine(Indent(4) + "4. Load Goals");
            Console.WriteLine(Indent(4) + "5. Record Events");
            Console.WriteLine(Indent(4) + "6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
        }
    }
}