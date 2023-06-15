public class Reflection : Activity {
    private List<string> _promptsList = new List<string>();
    private List<string> _followUpList = new List<string>();
    private List<int> _followUpIndex = new List<int>(); //exists for non-destructive use of _followUpList
    private Random random = new Random();

    public Reflection() {
        _promptsList.Add("Think of a time when you stood up for someone else.");        
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless."); 

        _followUpList.Add("Why was this experience meaningful to you?");
        _followUpList.Add("Have you ever done anything like this before?");
        _followUpList.Add("How did you get started?");
        _followUpList.Add("How did you feel when it was complete?");
        _followUpList.Add("What made this time different than other times when you were not as successful?");
        _followUpList.Add("What is your favorite thing about this experience?");
        _followUpList.Add("What could you learn from this experience that applies to other situations?");
        _followUpList.Add("What did you learn about yourself through this experience?");
        _followUpList.Add("How can you keep this experience in mind in the future?");

        for (int i = 1; i <= _followUpList.Count; i++) {
            _followUpIndex.Add(i);
        }
    }
    public void prompt() {
        _timeLimit = SetTimeLimit();

        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        
        // get a random prompt from _promptsList by index
        int promptIndex = random.Next(_promptsList.Count);
        string randomPrompt = _promptsList[promptIndex];

        Console.WriteLine(randomPrompt);

        Console.WriteLine("\nHow many questions would you like to see?\n");
        string input = Console.ReadLine();
    
        if (int.TryParse(input, out int questionCount)) {
            if (questionCount > 9) {
                questionCount = 9;
            }

            int timeForEach = _timeLimit / questionCount;
        
            while (questionCount > 0) {
                int index = random.Next(_followUpIndex.Count); // get an integer between 0 and the total number of strings in _followUpIndex - 1
                int value = _followUpIndex[index]; // value should be unique every iteration, index doesn't need to
                _followUpIndex.RemoveAt(index); // remove integer by index from the list after getting the value at index

                // // for debugging
                // Console.WriteLine($"--at index {index} of _followUpIndex the value is {value}--\n--_followUpIndex count is {_followUpIndex.Count}--");

                // get a follow up question by index
                string randomFollowUp = _followUpList[index];
                Console.WriteLine(randomFollowUp);

                questionCount -= 1;
                Loading(timeForEach); //wait a few seconds before next prompt
            }
        }
        else {
            Console.WriteLine($"Invalid input. Please enter an integer between 1 and {_followUpList.Count}.");
            prompt();
        }
        Console.WriteLine($"Good job! You did this exercise for {_timeLimit} seconds.");
    }
}