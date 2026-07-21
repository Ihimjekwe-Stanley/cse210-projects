using System;

/*
Creativity:
1. The program hides only words that are still visible.
2. It hides three random words each round.
3. The program can easily be expanded into a scripture library by creating
   multiple Scripture objects and selecting one randomly.
*/

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(
            reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths."
        );

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type quit: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program finished.");
    }
}