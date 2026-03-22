using System;

class Program
{

    /***
    -Various scriptures in order to random select one
    -You can set how many words one to hide each time

    ***/
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();
        Console.WriteLine("How many words do you want to hide each time?");
        int numberWordsHide = int.Parse(Console.ReadLine());
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("1Nephi", 1, 1),
                "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."
            ),
            new Scripture(
                new Reference("Mosiah", 2, 41),
                "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."
            ),
            new Scripture(
                new Reference("James", 1, 5),
                "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."
            )
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nENTER to continue or 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(numberWordsHide);
        }

        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Game Over");
    }
}