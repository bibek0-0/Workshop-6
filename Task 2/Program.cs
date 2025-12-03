public delegate int Calculate(int a, int b);
public delegate double DiscountStrategy(double price);

class Operations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
}

class Discounts
{
    public double FestivalDiscount(double price) => price * 0.80;
    public double SeasonalDiscount(double price) => price * 0.90;
    public double NoDiscount(double price) => price;
}

class Program
{
    static void Main()
    {
        Operations ops = new Operations();

        Calculate calc = ops.Add;
        Console.WriteLine("Add: " + calc(10, 5));

        calc = ops.Subtract;
        Console.WriteLine("Subtract: " + calc(10, 5));

        Discounts d = new Discounts();
        Console.WriteLine("Festival: " + d.FestivalDiscount(1000));
        Console.WriteLine("Seasonal: " + d.SeasonalDiscount(1000));
        Console.WriteLine("No Discount: " + d.NoDiscount(1000));
    }
}
