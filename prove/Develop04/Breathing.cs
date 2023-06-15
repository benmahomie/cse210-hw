public class Breathing : Activity {
    private int _breathCount = 4;
    private int _secondsToBreathe;
    public void prompt() {

        _timeLimit = SetTimeLimit();
        _secondsToBreathe = _timeLimit / _breathCount;

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        Loading(2);
        breathe(_breathCount);        
    }

    public void breathe(int iterations) {
        while (iterations > 0) {

            Console.Write("Breathe in... ");
            Countdown(_secondsToBreathe / 2);
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);

            Console.Write("Breathe out... ");
            Countdown(_secondsToBreathe / 2);
            Console.SetCursorPosition(Console.CursorLeft - 15, Console.CursorTop);

            iterations -= 1;
        }
        Console.WriteLine($"Good job! You did this exercise for {_timeLimit} seconds.");
    }
}