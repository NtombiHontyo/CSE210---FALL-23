using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string answer = Console.ReadLine();
        int numberAnswer = int.Parse(answer);

        

        while (numberAnswer < magicNumber)
        {
            Console.WriteLine("Higher");
            Console.Write("What is your guess? ");
            answer = Console.ReadLine();
            numberAnswer = int.Parse(answer);
        }
        while (numberAnswer > magicNumber)
        {
             Console.WriteLine("Lower");
             Console.Write("What is your guess? ");
             answer = Console.ReadLine();
             numberAnswer = int.Parse(answer);
        }
        

        Console.WriteLine("You guessed it!");
    }
    //Add question inside loop
}