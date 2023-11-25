public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
//Constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 1;
        _prompts = new List<string>();
        string prompt1 = "Who are the people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes";

        
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
         _prompts.Add(prompt3);
         _prompts.Add(prompt4);
         _prompts.Add(prompt5);  
    }
     public void Run()
     {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in:  ");
        ShowCountDown(8);
        Console.WriteLine();
        
        GetListFromUser();
     }
     public void GetRandomPrompt()
     {
           

         Random randomGenerator = new Random();
         int promptToShow = randomGenerator.Next(0, _prompts.Count);
         string selectedPrompt = _prompts[promptToShow];
         Console.WriteLine($"---- {selectedPrompt} ----");
     }
     public List<string> GetListFromUser()
     {
        List<string> userList = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime FutureTime = currentTime.AddSeconds(_duration); 
        while (DateTime.Now < FutureTime)
        {
          Console.Write("> ");  
         string userAnswer = Console.ReadLine();
         userList.Add(userAnswer);
         
        }
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items");
        return userList;
     }
}