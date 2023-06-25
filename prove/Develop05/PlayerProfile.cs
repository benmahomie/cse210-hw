using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class PlayerProfile {
    protected int _score;
    protected int _goalCount = 0;
    protected List<Goals> _playerGoalList = new List<Goals>();
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
                CreateGoal();
                break;
            case 2:
                Console.WriteLine("Which goal are you recording?");
                for (int i = 0; i < _playerGoalList.Count; i++) {
                    Console.WriteLine($"{i+1}. {_playerGoalList[i].GetGoalName()}");
                }

                int goalChoice = (int.Parse(Console.ReadLine())) - 1;
                _playerGoalList[goalChoice].RecordEvent();
                break;
            case 3:
                for (int i = 0; i < _playerGoalList.Count; i++) {
                    Console.WriteLine($"{_playerGoalList[i].PrintGoal()}");
                };
                break;
            case 4:
                Console.WriteLine(_score);
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

    public void CreateGoal() {
        Console.WriteLine("What type of goal will you create?\n1. Simple Goal (One and Done)\n2. Repeating Goal (Never Ends)\n3. Checklist Goal (Repeating Activity with Bonuses on Intervals)");
        int input = int.Parse(Console.ReadLine());

        switch (input) {
            case 1:
                Console.WriteLine("--Simple Goal--");

                Console.WriteLine("Enter the Simple Goal title: ");
                string simpleGoalTitle = Console.ReadLine();

                Console.WriteLine("Enter the point value of the Simple Goal: ");
                int simpleGoalValue = int.Parse(Console.ReadLine());

                Goals simpleGoal = new SimpleGoal(simpleGoalTitle, simpleGoalValue);
                _playerGoalList.Add(simpleGoal);
                _goalCount += 1;
                break;
            case 2:
                Console.WriteLine("--Repeating Goal--");
                
                Console.WriteLine("Enter the Repeating Goal title: ");
                string repeatingGoalTitle = Console.ReadLine();

                Console.WriteLine("Enter the point value of the Repeating Goal: ");
                int repeatingGoalValue = int.Parse(Console.ReadLine());

                RepeatingGoal repeatingGoal = new RepeatingGoal(repeatingGoalTitle, repeatingGoalValue);
                _playerGoalList.Add(repeatingGoal);
                _goalCount += 1;
                break;
            case 3:
                Console.WriteLine("--Checklist Goal--");

                Console.WriteLine("Enter the Checklist Goal title: ");
                string intervalGoalTitle = Console.ReadLine();

                Console.WriteLine("Enter the point value of the Checklist Goal: ");
                int intervalGoalValue = int.Parse(Console.ReadLine());

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

    public void SaveGoals() {
        string jsonString = JsonSerializer.Serialize(_playerGoalList);
        File.WriteAllText("goals.json", jsonString);

        Console.WriteLine("JSON file saved.");
    }
}