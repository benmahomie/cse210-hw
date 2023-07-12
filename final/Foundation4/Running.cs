public class Running : Activity {
    private double _distance; // distance in kilometers

    public Running(string date, double minuteLength, double distance) {
        _activity = "Running";
        _date = date;
        _minuteLength = minuteLength;
        _distance = distance;
    }

    public override double GetDistance() {
        return _distance;
    }
    public override double GetSpeed() {
        return (_distance / _minuteLength) * 60;
    }
}