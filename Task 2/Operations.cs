public delegate int Calculate(int a, int b);
public delegate double DiscountStrategy(double price);

public class Operations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
}

public class Discounts
{
    public double FestivalDiscount(double price) => price * 0.80;
    public double SeasonalDiscount(double price) => price * 0.90;
    public double NoDiscount(double price) => price;
}
