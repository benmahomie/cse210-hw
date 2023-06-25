public abstract class Goals : PlayerProfile {
    protected string _goalTitle;
    protected int _goalValue;
    protected string _goalComplete;
    protected int _interval;
    protected int _timesRepeated = 0;

    public string GetGoalName() {
        return _goalTitle;
    }

    public virtual void RecordEvent() {
        UpdateGoalCompletion();
        _score += _goalValue;
    }

    public string PrintGoal() {
        return $"Goal: {_goalTitle}\nPoint Value: {_goalValue}\nCompleted: {_goalComplete}";
    }

    public abstract void UpdateGoalCompletion();

    public void AwardPoints() {
    _score += _goalValue;
    }
}