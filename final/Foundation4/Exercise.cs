public class Exercise
{
    protected string _date;
    protected int _length;
    protected string _exerciseType;
    public Exercise(string date, int length, string exerciseType)
    {
        _date = date;
        _length = length;
        _exerciseType = exerciseType;
    }
    public virtual double CalculateDistance()
    {
        return (CalculateSpeed() * _length) / 60;
    }
    public virtual double CalculateSpeed()
    {
        return (CalculateDistance() / _length) * 60;
    }
    public virtual double CalculatePace()
    {
        return _length / CalculateDistance();
    }
    public string DispaySummary()
    {
        return $"{_date} {_exerciseType} ({_length}) - Distance: {CalculateDistance()}km, Speed: {CalculateSpeed()}km/h, Pace: {CalculatePace()}m/km.";
    }
}