public abstract class Goals : PlayerProfile {
    protected string _goalTitle;
    protected int _goalValue;
    protected string _goalComplete;

    public void CreateGoal() {
        Console.WriteLine("What type of goal will you create?\n1. Simple Goal (One and Done)\n2. Repeating Goal (Never Ends)\n3. Checklist Goal (Repeating Activity with Bonuses on Intervals)");
        int input = int.Parse(Console.ReadLine());

        switch (input) {
            case 1:
                Console.WriteLine("--Simple Goal--");

                (string simpleGoalTitle, int simpleGoalValue) = GetTitleAndValue();

                SimpleGoal simpleGoal = new SimpleGoal(simpleGoalTitle, simpleGoalValue);
                _playerGoalList.Add(simpleGoal);
                _goalCount += 1;
                break;
            case 2:
                Console.WriteLine("--Repeating Goal--");
                
                (string repeatingGoalTitle, int repeatingGoalValue) = GetTitleAndValue();

                RepeatingGoal repeatingGoal = new RepeatingGoal(repeatingGoalTitle, repeatingGoalValue);
                _playerGoalList.Add(repeatingGoal);
                _goalCount += 1;
                break;
            case 3:
                Console.WriteLine("--Checklist Goal--");

                (string intervalGoalTitle, int intervalGoalValue) = GetTitleAndValue();

                IntervalGoal intervalGoal = new IntervalGoal(intervalGoalTitle, intervalGoalValue);

                intervalGoal.SetRepetitionAndBonus();
                _playerGoalList.Add(intervalGoal);
                _goalCount += 1;
                break;
            default:
                Console.WriteLine($"'{input}' is not a valid choice.");
                break;

            }
        }

        public void RecordEvent() {
            foo;
        }

        public abstract void PrintGoal();

        public abstract void UpdateGoalCompletion();

        public abstract (string, int) GetTitleAndValue();

        public void AwardPoints() {
        _score += _goalValue;
    }
}