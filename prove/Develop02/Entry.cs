public class Entry
{
    // Responsibilty of Entry Class: To prompt user to answer a random question. Date the response
    // and display the question, date and answer as a single entry.

    public string _userQuestion;
    public string _dateOfEntry;
    public string _userAnswer;

    public void DisplaySingleEntry()
    {
        Console.WriteLine($"{_dateOfEntry} - {_userQuestion} ");
        Console.WriteLine($"{_userAnswer}");
    }
}