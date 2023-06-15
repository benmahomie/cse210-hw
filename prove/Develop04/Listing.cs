public class Listing : Activity {
    private List<string> _promptsList = new List<string>();
    List<string> entries = new List<string>();
    private Random random = new Random();

    public Listing() {
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
    }

    public void prompt() {
        _timeLimit = SetTimeLimit();

        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        int index = random.Next(_promptsList.Count);
        string prompt = _promptsList[index];

        Console.WriteLine(prompt);
        Console.Write("\nThink about this prompt and be ready to write down your thoughts.\n");
        Countdown(5);
        Console.WriteLine("Write your thoughts, press Enter after each one.");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timeLimit);
        while (DateTime.Now < futureTime) {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(); // Move to the next line after the user presses Enter
                    continue;
                }

                string entry = key.KeyChar.ToString();
                entries.Add(entry);
            }
        } 
        Console.WriteLine("Time is up. You entered the following entries:");
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}