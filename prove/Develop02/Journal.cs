using System;
using System.IO;
public class Journal
{
    public string filename = "myJournal.txt";
    public string csvFilename = "myJournal.csv";
    public List<Entry> _entries = new List<Entry>();
    public void Write()
    {
        Entry newEntry = new Entry();
        newEntry._prompt = Prompt.RandomPrompt("promptlist.txt");
        _entries.Add(newEntry);

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{newEntry._currentDateTime}");
            outputFile.WriteLine($"{newEntry._prompt}");
            outputFile.WriteLine($"{newEntry._response}");
            outputFile.WriteLine();
        }
    }
    public void ExportToCSV()
    {
        using (StreamWriter outputFile = new StreamWriter(csvFilename))
        {
            // Write header row
            outputFile.WriteLine("Date,Prompt,Response");
            
            // Write each entry
            foreach (Entry entry in _entries)
            {
                // Escape commas and quotes in text for proper CSV format
                string date = entry._currentDateTime.ToString();
                string prompt = $"\"{entry._prompt.Replace("\"", "\"\"")}\"";
                string response = $"\"{entry._response.Replace("\"", "\"\"")}\"";
                
                outputFile.WriteLine($"{date},{prompt},{response}");
            }
        }
        
        Console.WriteLine($"Entries exported to {csvFilename}");
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