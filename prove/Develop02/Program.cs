using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;
        string dateString = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        string destPath = "journals\\journal.csv";
        string[] headerRow = {"Prompt", "Entry", "Date"};

        void AppendToCsv(string destPath, string[] newRow)
        {
            if (!File.Exists(destPath))
            {
                Console.WriteLine($"No file called '{destPath}'");
            }

            using (StreamWriter sw = File.AppendText(destPath))
            {
                sw.WriteLine(string.Join(",", newRow));
            }
        }

        Console.WriteLine(dateString);
        string prompt = "How was your day?";
        Console.WriteLine(prompt);
        string entry = Console.ReadLine();

        string[] newRow = {prompt, entry, dateString};

        AppendToCsv(destPath, newRow);
    }
}