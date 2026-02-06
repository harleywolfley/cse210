using System;
using System.IO;
public class Prompt
{

    public static string RandomPrompt(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        Random random = new Random();
        string line = random.GetItems(lines, 1)[0];
        return line;
    }
}