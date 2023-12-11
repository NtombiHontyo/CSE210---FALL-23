public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string date)
    {
        _eventTitle = title;
        _date = date;
    }
    public Event(string title, string description, string date, string time, Address adddress)
    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = adddress;
    }
    public string DisplayStandardDetails()
    {
        
        return $"{_eventTitle} \n{_description} \nDate: {_date} \nTime{_time} \n{_address.Display()}";
    }
    
}