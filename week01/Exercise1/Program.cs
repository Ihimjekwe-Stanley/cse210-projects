using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your frist name?");
        String name1 = Console.ReadLine();
        Console.Write("What is your last name?");
        String name2 = Console.ReadLine();
        Console.Write($"Your name is {name2}, {name1} {name2}.");
    }
}