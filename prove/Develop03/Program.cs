using System;

class Program
{
    static void Main(string[] args)
    {
        //object for the referance class
        Referance scripturereferance1 = new Referance("Alma", 5, 5);
        
        //object for the Scripture class
        Scripture scripture = new Scripture(scripturereferance1, "I can do all things");
        
        Console.Clear();
        scripture.GetDisplayText();
        Console.WriteLine();
        Console.WriteLine("Please press enter or type quit to finish");
        string userInput = Console.ReadLine();
        while (userInput != "quit")
        {
            Console.Clear();
            scripture.HideRandomWords(5);
            scripture.GetDisplayText();
            Console.WriteLine();
            Console.WriteLine("Please press enter or type quit to finish");
            userInput = Console.ReadLine();

            
        }
    }
}