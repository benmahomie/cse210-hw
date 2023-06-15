public class Activity {
    protected int _timeLimit;
    private bool _firstRun = true;

    public void Menu() {
        if (_firstRun == true) {
            Console.WriteLine("Welcome to the Mindfulness App.");
            Console.WriteLine("Please enter a number to choose an activity:");
            _firstRun = false;
        }
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflection");
        Console.WriteLine("4. Quit");

        string input = Console.ReadLine();
    
        if (int.TryParse(input, out int choice)) {

            switch (choice) {

                case 1: 
                    Breathing breathing = new Breathing();
                    breathing.prompt();
                    break;

                case 2: 
                    Listing listing = new Listing();
                    listing.prompt();
                    break;

                case 3:
                    Reflection reflection = new Reflection();
                    reflection.prompt();
                    break;

                case 4: 
                    Console.Write("Quitting...");
                    Loading(2);
                    return;

                default:
                    Console.WriteLine($"Invalid choice '{choice}'. Please enter a valid integer choice (1, 2, 3, or 4).");
                    break;
            }
        }
        else {
            Console.WriteLine("Invalid input. Please enter a valid integer choice (1, 2, 3, or 4).");
        }

        Console.WriteLine();
        Menu();
    }

    public void Loading(int seconds) {
        char[] spinner = new char[] { '-', '\\', '|', '/' };
        int i = 0;
        int loop = 0;

        while ((loop / 8) < seconds)
        {
            Console.Write(spinner[i]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            i = (i + 1) % spinner.Length;
            loop += 1;

            Thread.Sleep(100);
        }
    }

    public void Countdown(int seconds) {

        for (int i = seconds; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int SetTimeLimit() {
        Console.WriteLine("How long, in seconds, would you like your session to last?");
        int input = int.Parse(Console.ReadLine());
        return input;
    }
}