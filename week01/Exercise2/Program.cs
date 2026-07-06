using System;

class Program
{
    static void Main(string[] args)
    {
         // Ask the user for the grade
        Console.Write("What grade did you obtain? ");
        double grade = double.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign (+ or -)
        double lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle special cases
        if (letter == "A" && sign == "+")
        {
            sign = "";     // There is no A+
        }

        if (letter == "F")
        {
            sign = "";     // There is no F+ or F-
        }

        // Display the final grade
        Console.WriteLine($"You have earned the grade {letter}{sign}");

        // Display pass/fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, please try the course again.");
        }
    }
}
        
    


    
