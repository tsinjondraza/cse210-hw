using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new();
        s.SetColor("blue");
        s.SetSide(4.5f);

        Rectangle r = new();
        r.SetColor("yellow");
        r.SetLength(6);
        r.SetWidth(3.2f);

        Circle c = new();
        c.SetColor("green");
        c.SetRadius(40.1f);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(c);
        shapes.Add(r);
        shapes.Add(s);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
        }

    }
}