public class RepeatingGoal : Goals {

    public RepeatingGoal(string goalTitle, int goalValue) {
        _goalTitle = goalTitle;
        _goalValue = goalValue;
        _goalComplete = $"{_timesRepeated} times";
    }

    public override void UpdateGoalCompletion() {
        _timesRepeated += 1;
        _goalComplete = $"{_timesRepeated} times";
    }
}