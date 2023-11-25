using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        while(option != "4")
        {
            Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        Console.Write("Select a choice from the menu: ");
        option = Console.ReadLine();
        
        if (option == "1")
        {
            BreathingActivity bactivity = new BreathingActivity();
            bactivity.DisplayStartingMessage();
            bactivity.Run();
            bactivity.DisplayEndingMessage();
            
        }
        else if (option == "2")
        {
            ReflectingActivity ractivity = new ReflectingActivity();
            ractivity.DisplayStartingMessage();
            ractivity.Run();
            ractivity.DisplayEndingMessage();
        }
        else if (option == "3")
        {
            ListingActivity lactivity = new ListingActivity();
            lactivity.DisplayStartingMessage();
            lactivity.Run();
            lactivity.DisplayEndingMessage();
        }
        }

    }
}