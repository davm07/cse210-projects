using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _eventType;

    public Event()
    {

    }

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }
}