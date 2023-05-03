using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string dateString = DateTime.Now.ToString("dddd - dd MMMM yyyy");
        string destPath = "journals\\journal.csv";
        string[] headerRow = {"Date", "Prompt", "Entry"};

        void AppendToCsv(string destPath, string[] newRow)
        {
            if (!File.Exists(destPath))
            {
                Console.WriteLine($"\nNo file called '{destPath}'");
                using (StreamWriter sw = File.AppendText(destPath))
                {
                    sw.WriteLine(string.Join(",", headerRow));
                }
                Console.WriteLine($"Created file path '{destPath}'");
                Console.WriteLine("");
            }

            else
            {
                using (StreamWriter sw = File.AppendText(destPath))
                {
                    sw.WriteLine(string.Join(",", newRow));
                }
            }
        }
        
        Console.WriteLine(dateString);
        string entry = "";

        while (entry != "quit")
        {
            // print prompt
            Prompt promptInstance = new Prompt();
            string prompt = promptInstance.GetRandomPrompt();
            Console.WriteLine(prompt);

            // get entry from user
            entry = Console.ReadLine();

            if (entry != "quit")
            {
                // format newRow to pass to csv
                string[] newRow = {dateString, prompt, entry};

                // add to the csv file
                AppendToCsv(destPath, newRow);

                // ask if user wants another prompt
                Console.Write("Receive another prompt? (y/N): ");
                string addPrompt = Console.ReadLine();
                if (addPrompt != "y")
                {
                    entry = "quit";
                }
            }
        }
    }
}