using System;
using System.IO;

public class Entry
{
    public DateTime currentDateTime = DateTime.Now;
    public string _prompt = "";
    public string _response = "";
    public void TextEntry()
    {
        Console.WriteLine($"{currentDateTime}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine("Please add your response: \n");
        _response = Console.ReadLine();
    }
    
}