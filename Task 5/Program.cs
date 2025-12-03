class CashierSales { public string Cashier; public double Sales; }
class Applicant { public int Age; }

class Program
{
    static void Main()
    {
        // Aggregation
        var sales = new List<CashierSales>
        {
            new CashierSales{Cashier="A", Sales=2000},
            new CashierSales{Cashier="B", Sales=4500},
            new CashierSales{Cashier="C", Sales=1500}
        };

        Console.WriteLine("Total cashiers: " + sales.Count());
        Console.WriteLine("Total sales: " + sales.Sum(s => s.Sales));
        Console.WriteLine("Highest: " + sales.Max(s => s.Sales));
        Console.WriteLine("Lowest: " + sales.Min(s => s.Sales));
        Console.WriteLine("Average: " + sales.Average(s => s.Sales));

        // Quantifiers
        var applicants = new List<Applicant>
        {
            new Applicant{Age=17},
            new Applicant{Age=20},
            new Applicant{Age=18}
        };

        Console.WriteLine("Any under 18? " + applicants.Any(a => a.Age < 18));
        Console.WriteLine("All above 16? " + applicants.All(a => a.Age > 16));

        // Element operators
        var songs = new List<int> { 120, 200, 250, 500 };

        Console.WriteLine("First: " + songs.First());
        Console.WriteLine("Last: " + songs.Last());
        Console.WriteLine("Above 4 min: " + songs.First(s => s > 240));
        Console.WriteLine("Safe > 10 min: " + songs.FirstOrDefault(s => s > 600));
    }
}
