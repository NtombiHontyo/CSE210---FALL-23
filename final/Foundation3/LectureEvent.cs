public class LectureEvent : Event
{
    private string _speakerName;
    private string _capacity;
    private string _eventType;
    public LectureEvent(string title, string description, string date, string time, Address adddress, string speakerName, string capacity, string eventType) : base(title, description, date, time, adddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
        _eventType = eventType;
    }
    public LectureEvent(string eventType, string title, string date) :base(title, date)
    {
        _eventType = eventType;
    }

    public string DisplayFullDetails()
    {
        return $"{_eventTitle} \n{_description} \nDate: {_date} \nTime{_time} \n{_address.Display()} \nSpeaker: { _speakerName}, \nCapacity: { _capacity}";
    }
    public string DisplayShortDescription()
    {
        return $"Event Type: {_eventType} \n{_eventTitle} \nDate: {_date}";
    }
}