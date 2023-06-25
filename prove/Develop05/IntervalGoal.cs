public class IntervalGoal : Goals {
    private int _interval;
    private int _bonus;
    private int _timesRepeated = 0;

    public IntervalGoal(string goalTitle, int goalValue) {
        _goalTitle = goalTitle;
        _goalValue = goalValue;
    }

    public override (string, int) GetTitleAndValue() {
        Console.WriteLine("Enter the Checklist Goal title: ");
            string goalTitle = Console.ReadLine();

            Console.WriteLine("Enter the point value of the Checklist Goal: ");
            int goalValue = int.Parse(Console.ReadLine());

            return (goalTitle, goalValue);
    }

    public override void PrintGoal() {
        Console.WriteLine($"Goal: {_goalTitle}");
        Console.WriteLine($"Point Value: {_goalValue}");
        Console.WriteLine($"Interval: {_interval}");
        Console.WriteLine($"Bonus: {_bonus}");
    }

    public override void UpdateGoalCompletion() {
        _timesRepeated += 1;
        if (_timesRepeated > _interval) {
            _timesRepeated = 0;
        }
    }
    
    public void SetRepetitionAndBonus() {
        Console.WriteLine("Enter the times Checklist Goal should repeat before a bonus is given: ");
        int repeat = int.Parse(Console.ReadLine());
        _interval = repeat;
        _goalComplete = $"{_timesRepeated}/{_interval} until next bonus.";

        Console.WriteLine("Enter the value of the bonus: ");
        int bonus  = int.Parse(Console.ReadLine());
        _bonus = bonus;
    }
}