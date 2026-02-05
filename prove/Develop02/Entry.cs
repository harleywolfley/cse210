using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public DateTime _currentDateTime = DateTime.Now;
    public string _prompt = "";
    public string _response = "";
    public void TextEntry(string prompt, string response, DateTime currentDateTime)
    {
        prompt = _prompt;
        response = _response;
        currentDateTime = _currentDateTime;
        Console.WriteLine($"{_currentDateTime}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("Please add your response: \n");
        _response = Console.ReadLine();
    }
    
}