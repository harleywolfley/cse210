using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string _theScript;
        // Display scripture
        Scripture myScripture = new Scripture();
        Reference myReference = new Reference();
        Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("What file are your scriptures in?");
        string filename = Console.ReadLine();
        _theScript = myScripture.Get(filename);
        myReference.Set(_theScript);
        myReference.SplitScript(_theScript);
        myReference.GetScript();
        myReference.DisplayRef();
    }
}