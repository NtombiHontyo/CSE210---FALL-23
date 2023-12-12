public class Running : Exercise
{
    private double _distance;
   
    public Running (string date, int length, double distance, string exerciseType) : base(date, length, exerciseType)
    {
        _distance = distance;
        
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    

}