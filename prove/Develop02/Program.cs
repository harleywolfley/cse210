using System;
using System.IO;

class Program
{
    static void Main(string[] args)
{
    Journal myJournal = new Journal();  
    while (true)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Edit");
        Console.WriteLine("6. Quit");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1)
        {
          myJournal.Write();  
        } else if (userInput == 2)
        {
            myJournal.Display();
        } else if (userInput == 3)
        {
            myJournal.Load();
        } else if (userInput == 4)
        {
            myJournal.Save();
        } else if (userInput == 5)
        {
            myJournal.Edit();
        } else if (userInput == 6)
        {
            break;
        } else
        {
            Console.WriteLine("Invalid input.");
        }
        
       
    }
}
}