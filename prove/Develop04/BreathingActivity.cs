public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DateTime currentTime = DateTime.Now;
        DateTime FutureTime = currentTime.AddSeconds(_duration); 
        while (DateTime.Now < FutureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();

        }
    }
}