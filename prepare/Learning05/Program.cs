using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square sq1 = new Square("Red", 3);
        shapes.Add(sq1);

        Rectangle rec1 = new Rectangle("Blue", 4, 5);
        shapes.Add(rec1);

        Circle cr1 = new Circle("Green", 6);
        shapes.Add(cr1);

        foreach (Shape shape in shapes)
        {
            string color = shape.MyColor;
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }


    }
}