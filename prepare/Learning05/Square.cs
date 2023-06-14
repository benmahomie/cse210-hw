public class Square : Shape {
    private double _side;

    public Square(double side, string color) {
        _side = side;
        _color = color;
    }

    public override double GetArea() {
        double area = Math.Pow(_side, 2);
        return area;
    }
}