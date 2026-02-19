using System;

class Assign
{
    string _studentName;
    string _topic;
    string _summary;
    public string GetSummary()
    {
        Console.WriteLine("What is the student's name?");
        _studentName = Console.ReadLine();
        Console.WriteLine("What is the topic?");
        _topic = Console.ReadLine();
        _summary = $"{_studentName} - {_topic}";
        return _summary;
    }
}