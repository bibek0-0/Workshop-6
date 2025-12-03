class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area => Length * Width;
    public double GetArea() => Length * Width;
    public double GetPerimeter() => 2 * (Length + Width);
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle { Length = 10, Width = 5 };

        Console.WriteLine("Area: " + rect.Area);
        Console.WriteLine("Perimeter: " + rect.GetPerimeter());
    }
}
