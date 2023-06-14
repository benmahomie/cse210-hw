List<Shape> shapeList = new List<Shape>();

Square square = new Square(2.5, "Red");
Circle circle = new Circle(2.5, "Blue");
Rectangle rectangle = new Rectangle(2.5, 4.5, "Green");

shapeList.Add(square);
shapeList.Add(circle);
shapeList.Add(rectangle);

foreach (Shape shape in shapeList) {
    Console.WriteLine($"Area: {shape.GetArea()}, Color: {shape.GetColor()}");
}