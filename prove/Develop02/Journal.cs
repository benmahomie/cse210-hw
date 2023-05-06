public class Journal
{
    string[] headerRow = {"Date", "Prompt", "Entry"};
    string journalPath = "journals\\journal.csv";

    public void AddEntry(string[] newRow)
    {
        if (!File.Exists(journalPath))
        {
            Console.WriteLine($"\nNo file called '{journalPath}'");
            using (StreamWriter sw = File.AppendText(journalPath))
            {
                sw.WriteLine(string.Join("|", headerRow));
            }
            Console.WriteLine($"Created file path '{journalPath}'");
            Console.WriteLine("");
        }

        else
        {
            using (StreamWriter sw = File.AppendText(journalPath))
            {
                sw.WriteLine(string.Join("|", newRow));
            }
        }
    }

    public void Display()
    {
        Console.WriteLine("");
        StreamReader reader = null;
        if (File.Exists(journalPath))
        {
            reader = new StreamReader(File.OpenRead(journalPath));
            List<string> wholeCsv = new List<string>();
            List<string> headerSection = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('|');
                foreach (var section in values)
                {
                    wholeCsv.Add(section);
                }
                wholeCsv.Remove("Date");
                wholeCsv.Remove("Prompt");
                wholeCsv.Remove("Entry");
                int counter = 0;
                foreach (var i in wholeCsv)
                {
                    Console.WriteLine(i);
                    // space out entries by pseudo floor division
                    counter += 1;
                    if ((counter - 3) == 0)
                    {
                        Console.WriteLine("");
                        counter = 0;
                    }
                }
            }
            reader.Close();
        }
        else 
        {
            Console.WriteLine($"{journalPath} could not be found.");
        }
    }

    public void MakeEntry()
    {
        DateTime date = DateTime.Now;
        string dateString = DateTime.Now.ToString("dddd - dd MMMM yyyy");

        // define entry, and get Prompt and Journal objects
        string entry = "";
        Prompt myPrompt = new Prompt();

        Console.WriteLine(dateString);

        while (entry != "quit")
        {
            // print prompt
            string prompt = myPrompt.GetRandomPrompt();
            Console.WriteLine(prompt);

            // get entry from user
            entry = Console.ReadLine();

            if (entry != "quit")
            {
                // format newRow to pass to csv
                string[] newRow = {dateString, prompt, entry};

                // add the current entry to the csv file
                AddEntry(newRow);

                // set entry as either "quit" or "" to exit or continue the program
                entry = myPrompt.MorePrompt();
            }
        }
    }
}