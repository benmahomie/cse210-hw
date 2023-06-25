public class IntervalGoal : Goals {
    private int _bonus;

    public IntervalGoal(string goalTitle, int goalValue) {
        _goalTitle = goalTitle;
        _goalValue = goalValue;
    }

    public override void UpdateGoalCompletion() {
        _timesRepeated += 1;
    }

    public override void RecordEvent() {
        UpdateGoalCompletion();
        if (_timesRepeated >= _interval) {
            _timesRepeated = 1;
            _goalComplete = $"{_timesRepeated}/{_interval}";
            _score += _bonus;
        }
        else {
            _score += _goalValue;
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