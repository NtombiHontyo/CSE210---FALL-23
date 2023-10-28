using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string answer = Console.ReadLine();
            int favNumber = int.Parse(answer);
            return favNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int numberSquared = userNumber * userNumber;
            return numberSquared;
        }

        


        DisplayWelcome();
        //PromptUserName();
        //PromptUserNumber();
        
        static void DisplayResult()
        {
            
            Console.WriteLine($"{PromptUserName()}, the square of your number is: {SquareNumber(PromptUserNumber())}");
        }

        DisplayResult();

        
    }
}