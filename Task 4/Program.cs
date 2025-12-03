class Book { public string Title; public double Price; }
class Student { public string Name; }

class Program
{
    static void Main()
    {
        // 1) Square numbers
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        var squares = nums.Select(n => n * n);
        Console.WriteLine(string.Join(", ", squares));

        // 2) Filter books
        List<Book> books = new List<Book>
        {
            new Book{Title="A", Price=800},
            new Book{Title="B", Price=1500},
            new Book{Title="C", Price=2000},
        };

        var premium = books.Where(b => b.Price > 1000);
        foreach (var b in premium)
            Console.WriteLine($"{b.Title} - Rs. {b.Price}");

        // 3) Sort students
        List<Student> students = new List<Student>
        {
            new Student{Name="Hari"},
            new Student{Name="Bina"},
            new Student{Name="Azad"}
        };

        var sorted = students.OrderBy(s => s.Name);
        foreach (var s in sorted)
            Console.WriteLine(s.Name);
    }
}
