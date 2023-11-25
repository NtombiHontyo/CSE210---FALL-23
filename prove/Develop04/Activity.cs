public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
//Constructor
    public Activity()
    {
        _name = "name";
        _description = "description";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}. ");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("Please enter the duration of your activity: ");
        string userAnswer = Console.ReadLine();
        _duration = int.Parse(userAnswer);
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} and did so in {_duration} seconds");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<char> charList = new List<char>();

        charList.Add('\\');
        charList.Add('|');
        charList.Add('/');
        charList.Add('-');
        charList.Add('\\');

        DateTime currentTime = DateTime.Now;
        DateTime FutureTime = currentTime.AddSeconds(seconds);
        int i =0; 
        while (DateTime.Now < FutureTime)
        {
            char s = charList[i]  ;
            Console.Write(s);
            Thread.Sleep(400);
            Console.Write("\b \b");

            i++;

            if (i >= charList.Count)
            {
                i = 0;
            }  
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}