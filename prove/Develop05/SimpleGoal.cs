public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal() : base()
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
       // _isComplete = false;
    }
    public override void RecordEvent()
    {
        int earnedPoints = _points;
        Console.WriteLine($"Congratulations, you have earned {earnedPoints} points!");
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}