using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {        
        Journal myJournal = new Journal();

        Console.WriteLine("  __  __");
        Console.WriteLine(" |  \\/  |");
        Console.WriteLine(" | \\  / |  ___  _ __   _   _ ");
        Console.WriteLine(" | |\\/| | / _ \\| '_ \\ | | | |");
        Console.WriteLine(" | |  | ||  __/| | | || |_| |");
        Console.WriteLine(" |_|  |_| \\___||_| |_| \\__,_|");

        Console.WriteLine("");
        Console.WriteLine("1. Write Entries");
        Console.WriteLine("2. Read Journal");
        Console.WriteLine("3. Quit program");

        bool loop = true;
        while (loop == true)
        {
            Console.Write("Enter Menu Option (1, 2, or 3): ");
            string menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
                myJournal.MakeEntry();
            }

            else if (menuOption == "2")
            {
                myJournal.Display();
            }
            else if (menuOption == "3")
            {
                Console.WriteLine("Exit journal program? (Y/n)");
                string exit = Console.ReadLine();

                if (exit != "n")
                {
                    Console.WriteLine("Exiting program..."); 
                    loop = false;                  
                }
            }
            else
            {
                Console.WriteLine($"'{menuOption}' is not a valid option.");
            }
        }            
    }
}