class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        Square square = new(2, "blue");
        Rectangle rect = new(2, 5, "black");
        Circle circle = new(4, "red");
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circle);

        foreach (Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();
            Console.WriteLine($"Color: {color}, Area: {area:F2}");
        }
    }
}