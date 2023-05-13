using System;

class Program
{
    static void Main(string[] args)
    {   
        static void DisplayMenu() 
        {   
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            List<string> options = new List<string>() 
                                        {
                                            "1. Write",
                                            "2. Display",
                                            "3. Load",
                                            "4. Save",
                                            "5. Quit"
                                        }; 
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        Journal newJournal = new Journal();
        int option = -1;
        while (option != 5)
        {
            DisplayMenu();
            Console.Write("What would you like to do? ");
            try
            {
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {   
                    PromptGenerator newPrompt = new PromptGenerator();
                    Entry userEntry = new Entry();
                    string promptSelected = newPrompt.SelectPrompt();
                    userEntry._prompt = promptSelected;
                    Console.WriteLine(promptSelected);
                    Console.Write("> ");
                    userEntry._entry = Console.ReadLine();
                    newJournal.AddEntry(userEntry);

                } else if (option == 2) 
                {
                    newJournal.DisplayEntry();
                } else if (option == 3) 
                {   
                    Console.Write("Please enter the name of the file: ");
                    string filename = Console.ReadLine();
                    newJournal.LoadFromFile(filename);
                } else if (option == 4)
                {
                    Console.Write("Please enter the name of the file: ");
                    string filename = Console.ReadLine();
                    newJournal.SaveToFile(filename);
                }
            } 
            catch(FormatException)
            {
                Console.WriteLine("Please enter only the numbers that are in the menu");
                Console.WriteLine("Don't input letters");
            }
            catch(FileNotFoundException)
            {   
                Console.WriteLine("That file doesn't exists please enter the correct file name!");
            }
        }
    }
}