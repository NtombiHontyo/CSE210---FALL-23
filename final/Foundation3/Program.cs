using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("5 Buller Street", "East London", "Eastern Cape", "South Africa");
        LectureEvent lectureEvent = new LectureEvent("General Conferance", "This is the 120th Semi-annual General Conferance", "20 September 2023", "10:00", address, "President Nelson", "800", "Lecture Event");

       
        Console.WriteLine(lectureEvent.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.DisplayShortDescription());
        Console.WriteLine();

        Address address1 = new Address("10 Byron Street", "Cape Town", "Western Cape", "Zambia");

        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding", "Tali Weds Chase", "17 October 2041", "10:30", address1, "ntombistengile001@gmail.com", "Reception");

        Console.WriteLine(receptionEvent.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.DisplayShortDescription());
        Console.WriteLine();

        Address address2 = new Address("11 Forthright Street", "Johannesburg", "Gauteng", "America");

        OutdoorEvent outdoorEvent = new OutdoorEvent("Coachella", "Various artists to perform.", "05 December 2016", "18:00", address2, "27 Celcius", "Outdoor Event");

        Console.WriteLine(outdoorEvent.DisplayStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.DisplayShortDescription());

        
    }
}