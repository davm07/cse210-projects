using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string StudentInfo
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public string TopicInfo
    {
        get { return _topic; }
        set { _topic = value; }
    }
    
}