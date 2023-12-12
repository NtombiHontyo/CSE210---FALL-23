using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("29 September 2014", 30, 4.8, "Running");

        Console.WriteLine(running.DispaySummary());

        Cycling cycling = new Cycling("13 January 1995", 30, 70, "Cycling");

        Console.WriteLine(cycling.DispaySummary());

        Swimming swimming = new Swimming("25 January 2024", 30, 2, "Swimming");

        Console.WriteLine(swimming.DispaySummary());
    }
}