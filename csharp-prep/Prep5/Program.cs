using System;

class Program
{
    static void Main(string[] args)
    {
        // Displays the message, "Welcome to the Program!"
        static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
        }

        // Asks for and returns the user's name (as a string)
        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        // Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int number) {
            int squaredNumber = number*number;
            return squaredNumber;
        }

        // Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string userName, int squaredNumber) {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        }

        // run the stuff
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squared = SquareNumber(favNumber);
        DisplayResult(userName, squared);

    }
}