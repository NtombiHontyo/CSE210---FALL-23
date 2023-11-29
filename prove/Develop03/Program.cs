using System;

class Program
{
    static void Main(string[] args)
    {
        //object for the referance class
        Referance scripturereferance1 = new Referance("The Family Proclamation", 1, 1);
        
        //object for the Scripture class
        Scripture scripture = new Scripture(scripturereferance1, "In the premortal realm, spirit sons and daughters knew and worshipped God as their Eternal Father and accepted His plan by which His children could obtain a physical body and gain earthly experience to progress toward perfection and ultimately realize their divine destiny as heirs of eternal life. The divine plan of happiness enables family relationships to be perpetuated beyond the grave. Sacred ordinances and covenants available in holy temples make it possible for individuals to return to the presence of God and for families to be united eternally ");
        
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