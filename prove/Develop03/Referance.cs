public class Referance
{
    //My attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    //These are constructors
    public Referance(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }
    public Referance(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // This is a method
    public string GetDisplayText()
    {
        string text = "";
        if (_endVerse == 0)
        {
            text = $"{_book} {_chapter}:{_verse} ";
        }
        else
        {
            text = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        return text;
    }
}