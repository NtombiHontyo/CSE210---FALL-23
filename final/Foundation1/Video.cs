public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment>_comments = new List<Comment>();

    public int GetNoOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideoDetails()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_author);
        Console.WriteLine(_length);
        Console.WriteLine(GetNoOfComments());
         foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
    
}
