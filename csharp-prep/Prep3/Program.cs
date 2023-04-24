using System;

class Program
{
    static void Main(string[] args)
    {
        // // prompt user for magicNumber variable
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // declare variable guess as integer type
        int guess = 0;

        do {
            // prompt user for guess variable
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess != magicNumber) {
                if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                }
                else {
                    Console.WriteLine("Higher");
                }
            }

        } while (guess != magicNumber);

        Console.WriteLine("You guessed it!");
    }
}