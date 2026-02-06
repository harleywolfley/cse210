using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public DateTime _currentDateTime = DateTime.Now;
    public string _prompt = Prompt.RandomPrompt("../../../promptlist.txt");
    public string _response = "";
    public void PromptForResponse()
    {
        Console.WriteLine($"{_currentDateTime}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("Please add your response:");
        _response = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_currentDateTime} - Prompt: {_prompt}\n{_response}");
    }
    public string SerializeToText()
    {
        return $"{_currentDateTime}%%{_prompt}%%{_response}%%";
    }

    public static Entry Deserialize(string oldEntry)
    {
        string[] parts = oldEntry.Split("%%");
        Entry aNewEntry = new Entry();
        aNewEntry._currentDateTime = DateTime.Parse(parts[0]);
        aNewEntry._prompt = parts[1];
        aNewEntry._response = parts[2];
        return aNewEntry;
    }
}