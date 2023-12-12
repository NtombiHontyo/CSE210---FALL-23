public class Swimming : Exercise
{
    private double _noOfLaps;
    public Swimming (string date, int length, double noOfLaps, string exerciseType) : base(date, length, exerciseType)
    {
        _noOfLaps = noOfLaps;
    }
    public override double CalculateDistance()
    {
        return _noOfLaps * 50/1000;
    }
}