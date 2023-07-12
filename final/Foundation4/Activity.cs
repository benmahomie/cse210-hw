public class Activity {
    protected string _activity;
    protected string _date;
    protected double _minuteLength;

    public void GetSummary() {
        Console.WriteLine($"{_date} {_activity} ({_minuteLength})- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public virtual double GetDistance() {
        return 0.0;
    }
    public virtual double GetSpeed() {
        return (GetDistance() / _minuteLength) * 60;
    }
    public double GetPace() {
        return (_minuteLength / GetDistance());
    }
}