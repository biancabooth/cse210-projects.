using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Square square1 = new Square("blue",4);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("green",5,2);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("red", 5);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        List<Shape> shapes1 = new List<Shape>();
        shapes1.Add(square1);
        shapes1.Add(rectangle1);
        shapes1.Add(circle1);
        foreach(Shape shape in shapes1)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());

        }




    }

}