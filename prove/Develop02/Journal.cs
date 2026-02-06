using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Write()
    {
        Entry newEntry = new Entry();
        newEntry.PromptForResponse();
        _entries.Add(newEntry);

    }
    public void Load()
    {
        Console.WriteLine($"Where would you like to load from?");
        string filename = Console.ReadLine();
        string contents = File.ReadAllText(filename);
        string[] entriesFromFile = contents.Split("\n");
        foreach (string entryFromFile in entriesFromFile)
        {
            if (entryFromFile == "")
            {
                continue;
            }
            _entries.Append(Entry.Deserialize(entryFromFile));
        }
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save()
    {
        Console.WriteLine($"Where would you like to save to?");
        string filename = Console.ReadLine();

        string contents = "";
        foreach (Entry entry in _entries)
        {
            contents += entry.SerializeToText() + '\n';
        } 
        File.WriteAllText(filename, contents);
    }
   
    public void Edit()
    {
        for (int entryAmount = 0; entryAmount < _entries.Count; entryAmount++)
        {
            Console.WriteLine($"{entryAmount + 1}.");
        }

        Console.WriteLine("Which entry number?");
        int number = int.Parse(Console.ReadLine()) - 1;

        Console.WriteLine("Enter new response: ");
        _entries[number]._response = Console.ReadLine();
    }

}