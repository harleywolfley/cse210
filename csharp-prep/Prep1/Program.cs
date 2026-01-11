using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.Write("First Name: ");
        string fname = Console.ReadLine();
        Console.Write("Last Name: ");
        string lname = Console.ReadLine();
        Console.WriteLine($"You are {lname}, {fname} {lname}.");
    }
}