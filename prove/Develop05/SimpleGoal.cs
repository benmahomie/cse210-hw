public class SimpleGoal : Goals {    

    public SimpleGoal(string title, int value) {
        _goalTitle = title;
        _goalValue = value;
        _goalComplete = "[ ]";
    }

    public override void UpdateGoalCompletion() {
        _goalComplete = "[X]";
    }
}