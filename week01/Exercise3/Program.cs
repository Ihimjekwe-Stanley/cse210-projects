using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string keepPlaying = "yes";

        while (keepPlaying.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            int secretNumber = random.Next(1, 101);

            int guessCount = 0;
            int guess = -1;

            while (guess != secretNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Would you like to play again (yes/no)? ");
            keepPlaying = Console.ReadLine();
        }
    }
}