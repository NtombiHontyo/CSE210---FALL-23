public class Word
{
    //My attributes
    private string _oneWord;
    private bool _isHidden;


    //This is a constructor
    public Word(string oneWord)
    {   
        _oneWord = oneWord;
         
        _isHidden = false;
    }
    //This is a Setter
    public void Hide()
    {
        _isHidden = true;
    }
    //This is a Setter
    public void Show()
    {
        _isHidden = false;
    }
    //This is a Getter
    public bool IsHidden()
    {
        return _isHidden;
    }

    //This is a method
    public string GetDisplayText()
    {
        if (_isHidden)
        {
             _oneWord = new string('_', _oneWord.Length);
            return  _oneWord;
        }
        else
        {
        return $"{_oneWord}";
        }
    }
}