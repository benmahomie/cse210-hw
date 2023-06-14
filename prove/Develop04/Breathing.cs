public class Breathing : Activity {

    private int _secondsToBreathe = 5;
    private int _totalTime;
    public void prompt() {
        Loading(2);

        // Console.WriteLine("How many seconds would you like to spend on each breath in the breathing activity? ");
        // _secondsToBreathe = int.Parse(Console.ReadLine());
        
        Console.WriteLine("How many complete breaths (in and out is one breath) do you want to take?");
        int iterationCount = int.Parse(Console.ReadLine());

        _totalTime = ((_secondsToBreathe * 2) + 2) * iterationCount;

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Loading(2);
        breathe(iterationCount);        
    }

    public void breathe(int iterations) {
        while (iterations > 0) {

            Console.Write("Breathe in... ");
            Countdown(_secondsToBreathe);
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);

            Console.Write("Breathe out... ");
            Countdown(_secondsToBreathe);
            Console.SetCursorPosition(Console.CursorLeft - 15, Console.CursorTop);

            iterations -= 1;
        }

        Console.WriteLine($"Good job! You did this exercise for {_totalTime} seconds.");
    }
}