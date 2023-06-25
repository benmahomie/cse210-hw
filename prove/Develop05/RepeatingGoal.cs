public class RepeatingGoal : Goals {
    private int _timesRepeated = 0;

    public RepeatingGoal(string goalTitle, int goalValue) {
        _goalTitle = goalTitle;
        _goalValue = goalValue;
    }

    public override void PrintGoal() {
        Console.WriteLine($"Goal: {_goalTitle}");
        Console.WriteLine($"Point Value: {_goalValue}");
        Console.WriteLine($"Times Repeated: {_timesRepeated}");
    }

    public override void UpdateGoalCompletion() {
        _timesRepeated += 1;
    }

    public override (string, int) GetTitleAndValue() {
            Console.WriteLine("Enter the Repeating Goal title: ");
                string goalTitle = Console.ReadLine();

                Console.WriteLine("Enter the point value of the Repeating Goal: ");
                int goalValue = int.Parse(Console.ReadLine());

                return (goalTitle, goalValue);
        }
}