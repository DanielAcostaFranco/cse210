using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Square("Red", 10);
        Shape shape2 = new Circle("Blue", 3);
        Shape shape3 = new Rectangle("Green", 7);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape a in shapes)
        {
            Console.WriteLine($"The area is: {a.GetArea()}.");
        }
    }



}