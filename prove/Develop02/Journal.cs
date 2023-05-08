public class Journal
{
    string[] headerRow = {"Date", "Prompt", "Entry"};
    string journalPath = "journals\\journal.csv";
    public List<List<string>> _entriesInMemory = new List<List<string>>();

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
                if (line != "Date|Prompt|Entry")
                {
                    string[] values = line.Split('|');
                    List<string> list = values.ToList();
                    int counter = 0;
                    foreach (var i in list)
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
            }
            reader.Close();
            // also print entries from this session in memory
            foreach(var line in _entriesInMemory)
            {
                foreach(var substring in line)
                {
                    Console.WriteLine(substring);
                }
                Console.WriteLine("");
            }
        }
        else 
        {
            Console.WriteLine($"{journalPath} could not be found.");
        }
    }

    public void MakeEntry()
    {
        // define entry, and get Prompt object
        string entry = "";
        Prompt myPrompt = new Prompt();

        while (entry != "quit")
        {
            DateTime date = DateTime.Now;
            string dateString = DateTime.Now.ToString("dddd - dd MMMM yyyy");
            Console.WriteLine(dateString);

            // print prompt
            string prompt = myPrompt.GetRandomPrompt();
            Console.WriteLine(prompt);

            // get entry from user
            entry = Console.ReadLine();

            if (entry != "quit")
            {
                // format newRow to pass to csv
                string[] newRow = {dateString, prompt, entry};

                // add the current entry to the entry list of lists
                List<string> newRowList = newRow.ToList();
                _entriesInMemory.Add(newRowList);

                // set entry as "quit" or "" respectively to exit or continue the program
                entry = myPrompt.MorePrompt();
            }
        }
    }
}