public class OutdoorEvent : Event
{
    private string _weather;
    
    private string _eventType;
    public OutdoorEvent(string title, string description, string date, string time, Address adddress, string weather, string eventType) : base(title, description, date, time, adddress)
    {
        _weather = weather;
        _eventType = eventType;
    }
    public OutdoorEvent(string eventType, string title, string date) :base(title, date)
    {
        _eventType = eventType;
    }

    public string DisplayFullDetails()
    {
        return $"{_eventTitle} \n{_description} \nDate: {_date} \nTime{_time} \n{_address.Display()} \nWeather: { _weather}";
    }
    public string DisplayShortDescription()
    {
        return $"Event Type: {_eventType} \n{_eventTitle} \nDate: {_date}";
    }
}    