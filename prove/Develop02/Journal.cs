using System.Runtime.CompilerServices;

public class Journal
{
    //Responsibilty of Journal class: To generate a list of entries made.
    // Iterate through each entry and display.
    // Store the entries in a file.
    // Load the entries from a file.

    public List<Entry> _listOfEntries = new List<Entry>();
    
    public void AddEntry(Entry newEntry)
    {
        _listOfEntries.Add(newEntry);
    }

    public void DisplayAllEntries()
    {

        foreach (Entry entry in _listOfEntries)
        {
            entry.DisplaySingleEntry();
        } 
    }

    public void SaveToFile(string fileName)
    {
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _listOfEntries)
            {
                outputFile.WriteLine($"{entry._dateOfEntry}~{entry._userQuestion}~{entry._userAnswer}");
            }
            
        }
    }

    public void LoadFromFile(string fileName)
    {
         string[] lines = System.IO.File.ReadAllLines(fileName);

foreach (string line in lines)
{
    string[] parts = line.Split("~");

    string datePart = parts[0];
    string questionPart = parts[1];
    string answerPart = parts[2];

    Console.WriteLine($"{datePart} - {questionPart} \n {answerPart}");
    }
    }
}