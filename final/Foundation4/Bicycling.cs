public class Bicycling : Activity {
    private double _speed; // speed in kilometers per hour

    public Bicycling(string date, double minuteLength, double speed) {
        _activity = "Bicycling";
        _date = date;
        _minuteLength = minuteLength;
        _speed = speed;
    }

    public override double GetDistance() {
        double distance = _minuteLength * (_speed / 60);
        return distance;
    }
    public override double GetSpeed() {
        return _speed;
    }
}