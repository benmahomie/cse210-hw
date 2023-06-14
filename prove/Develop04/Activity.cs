public class Activity {

    public void Menu() {
        Console.WriteLine("Welcome to the Mindfulness App.");
        Console.WriteLine("Please enter a number to choose an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Listing");
        Console.WriteLine("3. Reflection");

        int choice = int.Parse(Console.ReadLine());
        if (choice == 1) {
            Breathing breathing = new Breathing();
            breathing.prompt();
        }
        if (choice == 2) {
            Listing listing = new Listing();
            listing.prompt();
        }
        if (choice == 3) {
            Reflection reflection = new Reflection();
            reflection.prompt();
        }
        else {
            // Console.WriteLine($"\"{choice}\" is not a valid option.");
            Menu();
        }
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
}