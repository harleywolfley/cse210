using System;
using System.IO;
public class Prompt
{

    public static string RandomPrompt(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        Random random = new Random();
        int findIndex = random.Next(0, filename.Length);
        Console.WriteLine($"{lines[findIndex]}.");
        return lines[findIndex];
    }
}