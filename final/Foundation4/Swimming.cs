public class Swimming : Activity {
    private double _lapsCount;

    public Swimming(string date, double minuteLength, double lapsCount) {
        _activity = "Swimming";
        _date = date;
        _minuteLength = minuteLength;
        _lapsCount = lapsCount;
    }

    public override double GetDistance() {
        double distance = (_lapsCount * 50) / 1000;
        return distance;
    }
    public override double GetSpeed() {
        double speed = (GetDistance() / _minuteLength) * 60;
        return speed;
    }
}