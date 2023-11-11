using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string actualTime = theCurrentTime.ToShortDateString();
        Console.WriteLine(actualTime);
    }
}
