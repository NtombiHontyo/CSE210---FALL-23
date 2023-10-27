using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int runningTotal = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        numbers.Add(userNumber);

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userNumber = int.Parse(userInput); 
            numbers.Add(userNumber);  
        }
        numbers.Remove(0);
        foreach (int number in numbers)
        {
            runningTotal += number;
        }  

        Console.WriteLine($"The sum is: {runningTotal}"); 

        double total = runningTotal;
        double noOfNumbers = numbers.Count;
        double average = total / noOfNumbers;
        Console.WriteLine($"The average is: {average}"); 
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}