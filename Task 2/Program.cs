class Program
{
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return strategy(originalPrice);
    }

    static void Main()
    {
        Console.WriteLine("TASK 2:Delegate");

        Operations ops = new Operations();

        // Using Calculate delegate
        Calculate calc = ops.Add;
        Console.WriteLine("Add: " + calc(10, 5));

        calc = ops.Subtract;
        Console.WriteLine("Subtract: " + calc(10, 5));

        // Discount strategy
        Discounts d = new Discounts();



        Console.WriteLine("\n TASK 2.1: Discount Strategy");

        Console.WriteLine("Final (Festival): " + CalculateFinalPrice(1000, d.FestivalDiscount));
        Console.WriteLine("Final (Seasonal): " + CalculateFinalPrice(1000, d.SeasonalDiscount));
        Console.WriteLine("Final (No Discount): " + CalculateFinalPrice(1000, d.NoDiscount));

        // Lambda expression for 30% discount
        Console.WriteLine("Final (Lambda 30% Off): " + CalculateFinalPrice(1000, p => p * 0.70));
    }
}
