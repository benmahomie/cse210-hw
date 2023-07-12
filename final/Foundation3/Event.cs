public class Event {
    protected string _title;
    protected string _type;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public void PrintStandardDetails() {
        Console.WriteLine("--Event Standard Details--");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }
    public virtual void PrintFullDetails() {
        Console.WriteLine("Print the full details of the event.");
    }
    public void PrintShortDescription() {
        Console.WriteLine("--Event Short Description--");
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}