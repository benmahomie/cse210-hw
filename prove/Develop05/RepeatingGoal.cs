public class RepeatingGoal : Goals {

    public RepeatingGoal(string goalTitle, int goalValue) {
        _goalTitle = goalTitle;
        _goalValue = goalValue;
    }

    public override void UpdateGoalCompletion() {
        _timesRepeated += 1;
        _goalComplete = $"{_timesRepeated} times";
    }
}