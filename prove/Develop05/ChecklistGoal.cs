public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal() : base()
    {
        
    }
    public ChecklistGoal(string name, string description, int points): base(name, description, points)//(string name, string description, int target, int bonus) : base(name, description)
    {
      //  _target = target;
        //_bonus = bonus;
        //_amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString()
    {
        return $"[ ]{_shortName}: ({_description}) this is a checklist goal";
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}