using System;

class Program
{
    static void Main(string[] args)
    {
        // Word word1 = new Word("Diego");
        // Console.WriteLine(word1.DisplayText());

        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // Console.WriteLine(reference.MakeReference());

        string sentence1 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference1 = new Reference("Proverbs", 3, 5, 6);

        List<Scripture> scriptures = new();
        scriptures.Add(new(sentence1, reference1));
        Scripture myscripture = scriptures[0];
        // Console.WriteLine(myscripture.MakeScripture());
        
        string userChoice = "";
        // bool hidden = false;

        while(userChoice != "quit")
        {   
            Console.Clear();
            Console.WriteLine(myscripture.MakeScripture());
            if(myscripture.IsCompletlyHidden)
            {
                break;
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to finish");
            myscripture.HideWords();
            userChoice = Console.ReadLine();
        }
    }
}