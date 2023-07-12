Running running = new Running("18 Jul 2023", 20, 5.0);
Bicycling bicycling = new Bicycling("19 Jul 2023", 40, 7.5);
Swimming swimming = new Swimming("20 Jul 2023", 30, 100);

List<Activity> activityList = new List<Activity>{running, bicycling, swimming};

foreach (Activity activity in activityList) {
    activity.GetSummary();
    Console.WriteLine();
}