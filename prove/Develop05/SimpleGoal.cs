public class SimpleGoal : Goals {    

    public SimpleGoal(string title, int value) {
        _goalTitle = title;
        _goalValue = value;
        _goalComplete = " ";
    }

    public override void UpdateGoalCompletion() {
        _goalComplete = "X";
    }

    public override void PrintGoal() {
        Console.WriteLine($"Goal: {_goalTitle}");
        Console.WriteLine($"Point Value: {_goalValue}");
        Console.WriteLine($"Completed: [{_goalComplete}]");
    }

    public override (string, int) GetTitleAndValue() {
            Console.WriteLine("Enter the Simple Goal title: ");
                string goalTitle = Console.ReadLine();

                Console.WriteLine("Enter the point value of the Simple Goal: ");
                int goalValue = int.Parse(Console.ReadLine());

                return (goalTitle, goalValue);
        }
}