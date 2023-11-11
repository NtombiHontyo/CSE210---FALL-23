using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        //Initiating RandomStatementGenerator class
        RandomStatementGenerator randomstatementone = new RandomStatementGenerator();
        randomstatementone._questions.Add("Did someone or something make you laugh today? Tell me all about it, I also want to laugh.");
        randomstatementone._questions.Add("What new principle/concept did you learn today?");
        randomstatementone._questions.Add("What was the weather like today? Did it conrtibute towards your day?");
        randomstatementone._questions.Add("Do you remember what you dreamt about last night? If so, do tell.");
        randomstatementone._questions.Add("What interesting interaction did you with someone today?");


        //Initiating Journal class
        Journal journalpro = new Journal();



        Console.WriteLine("Please select one of the following choices:");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quite");

        Console.Write("What would you like to do?");
        string choiceNumberString = Console.ReadLine();
        int choiceNumber = int.Parse(choiceNumberString);

        while (choiceNumber != 5)
        {
            if (choiceNumber == 1)
            {
                string questionForJournal = randomstatementone.GenerateRandomStatement();
                Console.WriteLine(questionForJournal);
                Console.Write("~  ");
                string answer = Console.ReadLine();
                //Initiating Entry class
                Entry journalEntry = new Entry();

                journalEntry._userQuestion = questionForJournal;
                DateTime theDate = DateTime.Now;
                string entryDate = theDate.ToShortDateString();
                journalEntry._dateOfEntry = entryDate;
                journalEntry._userAnswer = answer;

                //For Entry list
                journalpro.AddEntry(journalEntry);
            }
            else if (choiceNumber == 2)
            {


                journalpro.DisplayAllEntries();
            }

            if (choiceNumber == 3)
            {
                Console.Write("What is the name of the file? ");
                string nameOfFile = Console.ReadLine();

                journalpro.SaveToFile(nameOfFile);
            }
            if (choiceNumber == 4)
            {
                Console.Write("What is the name of the file? ");
                string nameOfFileToRead = Console.ReadLine();

                journalpro.LoadFromFile(nameOfFileToRead);
            }

            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quite");

            Console.Write("What would you like to do?");
            choiceNumberString = Console.ReadLine();
            choiceNumber = int.Parse(choiceNumberString);
        }






    }
}