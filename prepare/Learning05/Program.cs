using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        
        Rectangle rectangle = new Rectangle("Orange", 8, 10);

        Circle circle = new Circle("Blue", 7);
      
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}  Area: {area}");
        }
    }
}