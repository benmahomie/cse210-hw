public class Circle : Shape {
    private double _radius;

    public Circle(double radius, string color) {
        _radius = radius;
        _color = color;
    }

    public override double GetArea() {
        double area = Math.PI * Math.Pow(_radius, 2);
        return area;
    }
}