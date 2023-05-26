using System;

class Program
{
    static void Main(string[] args)
    {
        // Word word1 = new Word("Diego");
        // Console.WriteLine(word1.DisplayText());

        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Console.WriteLine(reference.MakeReference());

        Scripture myscripture = new Scripture();
        // Console.WriteLine(myscripture.MakeScripture());
        
        
        string userChoice = "";

        while(userChoice != "quit")
        {   
            Console.Clear();
            Console.WriteLine(myscripture.MakeScripture());
            Console.WriteLine();
            Console.WriteLine("Type \"quit\" to end the program");
            List <string> list = myscripture.MakeList();
            myscripture.CreateHiddenScrip(list);
            userChoice = Console.ReadLine().ToLower();
            
        }

        
        
    }
}