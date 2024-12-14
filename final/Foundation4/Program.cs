using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("2023-09-01", 30, 7.0);
        Cycling cycling = new Cycling("2023-09-01", 60, 15.0);
        Swimming swimming = new Swimming("2023-09-01", 45, 20);

        Console.WriteLine("Running:");
        running.GetSummary();

        Console.WriteLine("\nCycling:");
        cycling.GetSummary();

        Console.WriteLine("\nSwimming:");
        swimming.GetSummary();
    }
}

