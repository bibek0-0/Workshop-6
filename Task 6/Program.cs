class Tour
{
    public string CustomerName;
    public string Destination;
    public double Price;
    public int DurationInDay;
    public bool IsInternational;
}

class Program
{
    static void Main()
    {
        var tours = new List<Tour>
        {
            new Tour{CustomerName="Ram", Destination="Japan", Price=50000, DurationInDay=7, IsInternational=true},
            new Tour{CustomerName="Sita", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false},
            new Tour{CustomerName="Hari", Destination="Bangkok", Price=30000, DurationInDay=5, IsInternational=true},
            new Tour{CustomerName="Gita", Destination="Chitwan", Price=12000, DurationInDay=5, IsInternational=false}
        };

        var filtered = tours.Where(t => t.Price > 10000 && t.DurationInDay > 4);

        var projected = filtered.Select(t => new
        {
            t.CustomerName,
            t.Destination,
            Category = t.IsInternational ? "International" : "Domestic",
            t.Price
        });

        var sorted = projected
            .OrderBy(t => t.Category)
            .ThenBy(t => t.Price);

        foreach (var item in sorted)
        {
            Console.WriteLine(
                $"Name: {item.CustomerName}, Destination: {item.Destination}, " +
                $"Category: {item.Category}, Price: {item.Price}");
        }
    }
}
