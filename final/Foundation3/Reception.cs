public class Reception : Event {
    private string _emailForRSVP;

    public Reception(string title, string description, string date, string time, Address address, string emailForRSVP) {
        _type = "Reception";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _emailForRSVP = emailForRSVP;
    }
    
    public override void PrintFullDetails() {
        PrintStandardDetails();
        Console.WriteLine($"Email for RSVP: {_emailForRSVP}");
    }
}