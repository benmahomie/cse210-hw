using System;

class Program
{
    static void Main(string[] args)
    {
        // get user input
        Console.Write("What is your grade percentage? ");
        string gradePercentageString = Console.ReadLine();
        // change string type to integer type
        int gradePercentage = int.Parse(gradePercentageString);

        // declare empty variable 'letter' so that the error messages go away
        string letter;

        // update letter variable with A,B,C,D, or F based on grade percentage
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Print success message if over 70, fail message if under
        if (gradePercentage >= 70) 
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass. Better luck next time!");
        }

        // print letter grade
        Console.WriteLine(letter);
    }
}