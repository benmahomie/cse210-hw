public class Lecture : Event {
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) {
        _type = "Lecture";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override void PrintFullDetails() {
        PrintStandardDetails();
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}