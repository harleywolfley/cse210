using System;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    public string _selectScript = "";
    public string Get(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        Random random = new Random();
        string _selectScript = random.GetItems(lines, 1)[0];
        Console.WriteLine($"Scripture Retrieved.");
        return _selectScript;
    }
    
}