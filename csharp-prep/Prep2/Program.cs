using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answerFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(answerFromUser);
        
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A"; 
        }
        else if (gradePercentage >= 80 )
        {
            letter = "B"; 
        }
        else if (gradePercentage >= 70 )
        {
            letter = "C"; 
        }
        else if (gradePercentage >= 60 )
        {
            letter = "D"; 
        }
        else if (gradePercentage < 60 )
        {
            letter = "F"; 
        }

        Console.WriteLine($"Grade: {letter}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class, please try harder next time.");
        }
    }
}