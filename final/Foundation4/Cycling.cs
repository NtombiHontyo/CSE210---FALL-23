public class Cycling : Exercise
{
    private double _speed;
    public Cycling (string date, int length, double speed, string exerciseType) : base(date, length, exerciseType)
    {
        _speed = speed;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
}