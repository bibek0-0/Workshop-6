class Program
{
    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int n in numbers)
            if (condition(n))
                Console.WriteLine(n);
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 12, 15, 20 };

        Console.WriteLine("Even Numbers:");
        ProcessNumbers(numbers, n => n % 2 == 0);

        Console.WriteLine("Numbers > 10:");
        ProcessNumbers(numbers, n => n > 10);
    }
}
