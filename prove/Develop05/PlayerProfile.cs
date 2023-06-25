public class PlayerProfile {
    protected int _score;
    protected int _goalCount;
    protected List<Goals> _playerGoalList;
    private string _playerName;
    private string _playerFavFood;

    public void SetPlayerDetails() {
        Console.WriteLine("What is your name?");
        _playerName = Console.ReadLine();
        Console.WriteLine("What is your favorite food?");
        _playerFavFood = Console.ReadLine();
    }

    public void DisplayScore() {
        Console.WriteLine($"Score: {_score}");
    }

    public void PlayerMenu() {
        int input = 0;
    while (input != 5) {
        Console.WriteLine("--Menu--");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. List goals");
        Console.WriteLine("4. Show score");
        Console.WriteLine("5. Save current goals & score then quit");
        Console.WriteLine();
        input = int.Parse(Console.ReadLine());

        switch (input) {
            case 1:
                Goals goal = new Goals();
                break;
            case 2:
                RecordEvent();
                break;
            case 3:
                ShowGoals();
                break;
            case 4:
                ShowScore();
                break;
            case 5:
                SaveGoals();
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }
        }
    }
}