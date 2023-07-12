public class OutdoorGathering : Event {
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherStatement) {
        _type = "Outdoor Gathering";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weatherStatement = weatherStatement;
    }
    
    public override void PrintFullDetails() {
        PrintStandardDetails();
        Console.WriteLine($"Statement of Weather: {_weatherStatement}");
    }
}