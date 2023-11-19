using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string text = "I can do all things"; // this is stored in the word object
        char delimeter = ' ';

        Console.WriteLine($"{text}");
        List<string> stringList = text.Split(delimeter).ToList();  //The list must use data from the Word class

        
        Console.WriteLine();
        Console.WriteLine("Please press enter or type quit to finish");
        
        string userInput = Console.ReadLine();
        while ( !AllWordsChangedToUnderscores(stringList))
        {
            Console.Clear();
            Random randomgen = new Random();
            int randomIndex = randomgen.Next(0, stringList.Count);


        string selectedWord = stringList[randomIndex];
        string underscore = new string('_', selectedWord.Length);
        stringList[randomIndex] = underscore;

            foreach (string item in stringList)
            {
                 Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Please press enter or type quit to finish");
            userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }
        }
        static bool AllWordsChangedToUnderscores(List<string> stringList)
    {
        // Check if all words in the list have changed to underscores
        foreach (string selectedWord in stringList)
        {
            if (selectedWord != new string('_', selectedWord.Length))
            {
                return false;
            }
        }
        return true;
    }
        
    }
}
