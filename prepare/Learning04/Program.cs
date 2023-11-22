using System;

class Program
{
    static void Main(string[] args)
    {
       // Assignment assignment = new Assignment("Samual Bennet", "Multiplication");
       // Console.WriteLine(assignment.GetSummary());

       // MathAssignment mathassignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
       // Console.WriteLine(mathassignment.GetSummary());
       // Console.WriteLine(mathassignment.GetHomeworkList());
       WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
       Console.WriteLine(writingAssignment.GetSummary());
       Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}