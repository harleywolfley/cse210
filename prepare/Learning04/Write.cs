using System;

class WriteLine : Assign
{
    private string _title;
    public string GetWrite()
    {
        Console.WriteLine("What is the title of the writing assignment?");
        _title = Console.ReadLine();
        return _title;
    }
}