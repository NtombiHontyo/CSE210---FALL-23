public class ReceptionEvent : Event
{
    private string _email;
    
    private string _eventType;
    public ReceptionEvent(string title, string description, string date, string time, Address adddress, string email, string eventType) : base(title, description, date, time, adddress)
    {
        _email = email;
        _eventType = eventType;
    }
    public ReceptionEvent(string eventType, string title, string date) :base(title, date)
    {
        _eventType = eventType;
    }

    public string DisplayFullDetails()
    {
        return $"{_eventTitle} \n{_description} \nDate: {_date} \nTime{_time} \n{_address.Display()} \nRSVP: { _email}";
    }
    public string DisplayShortDescription()
    {
        return $"Event Type: {_eventType} \n{_eventTitle} \nDate: {_date}";
    }
}        