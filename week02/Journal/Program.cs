using System;

/*
Added the LoadFromFile method to Journal.cs, which verifies the file's existence before attemting to read it.
*/

class Program
{
    private static void Option1(Journal j, Prompts p)
    {
        string onePrompt = p.GetAPrompt();
        Console.WriteLine(onePrompt);
        Console.Write("..> ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._prompt = onePrompt;
        newEntry._entry = response;

        j.AddEntry(newEntry);
    }
    private static void Option2(Journal j)
    {
        j.DisplayAll();
    }
    private static void Option3(Journal j)
    {
        Console.WriteLine("Please, give me the file name");
        string fileName = Console.ReadLine();
        j.LoadFromFile(fileName);
    }
    private static void Option4(Journal j)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        j.SaveToFile(fileName);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal theJournal = new Journal();
        Prompts prompts = new Prompts();
        string choice = "";

        Console.WriteLine("Welcome to your daily Journal");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1) Write");
            Console.WriteLine("2) Display");
            Console.WriteLine("3) Load");
            Console.WriteLine("4) Save");
            Console.WriteLine("5) Exit");
            Console.WriteLine("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5");
            }
            else if (choice == "1")
            {
                Option1(theJournal, prompts);
            }
            else if (choice == "2")
            {
                Option2(theJournal);
            }
            else if (choice == "3")
            {
                Option3(theJournal);
            }
            else if (choice == "4")
            {
                Option4(theJournal);
            }
        }
    }
}