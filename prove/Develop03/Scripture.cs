public class Scripture
{
    //My attributes
    private Referance _referance;
    private List<Word> _words;

    //THis is a constructor
    public Scripture(Referance referance, string text)
    {
        _referance = referance;
       // text = "I can do all things";
       _words = new List<Word>();
        char delimeter = ' ';
        string[] oneWord = text.Split(delimeter);
        foreach (string word in oneWord)
        {
            Word wordd = new Word(word);
            _words.Add(wordd);
        }
        
        
       // _words = new List<Word>();
       // _words.Add(stringList)
        
    }
    //These are methods
    public void HideRandomWords(int numberToHide)
    {
        Random randomgen = new Random();
        numberToHide = randomgen.Next(0, _words.Count);


        Word selectedWord = _words[numberToHide];
        selectedWord.Hide();
        selectedWord.IsHidden();
        selectedWord.GetDisplayText();
    }
    public void GetDisplayText()
    {
        Referance referance = new Referance("Alma", 5, 5);
        Console.Write(referance.GetDisplayText() + " ");
        
        foreach (Word word in _words)
        {
            
            Console.Write(word.GetDisplayText() + " ");
        }
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}