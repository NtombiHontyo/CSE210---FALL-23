using System;
public class Person
{
    public string _firstName = "";
    public string _lastname = "";
    public void DisplayWesternNameNotation()
    {
        Console.WriteLine($"{_firstName} {_lastname}" );
    }

    public void DisplayEasternNameNotation()
    {
        Console.WriteLine($"{_lastname}, {_firstName}" );
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._firstName = "Ntombi";  
        person._lastname = "Hontyo";

        person.DisplayEasternNameNotation(); 
    }
}