using System;

class Math : Assign
{
    private string _textbook;
    private string _problems;
    private string _hwlist;
    public string GetHWList()
    {
        Console.WriteLine("What is the textbook section? ");
        _textbook = Console.ReadLine();
        Console.WriteLine("What are the listed problems? ");
        _problems = Console.ReadLine();
        _hwlist = $"{_textbook} {_problems}";
        return _hwlist;
    }
}