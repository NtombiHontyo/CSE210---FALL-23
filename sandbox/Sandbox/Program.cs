using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOne = 3;
        int numberTwo = 4;

        double numberOneFloat = Convert.ToDouble(numberOne);
        double numberTwoFloat = Convert.ToDouble(numberTwo);

        Console.WriteLine(numberOneFloat/numberTwoFloat);

        string numberTwoString = Convert.ToString(numberOne);
        string numberOneString = Convert.ToString(numberTwo);

        Console.WriteLine($"{numberOneString}/{numberTwoString}");
    }
}
