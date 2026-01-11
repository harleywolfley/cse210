using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? \n");
        string enteredGrade = Console.ReadLine();
        int grade = int.Parse(enteredGrade);
        if (grade >= 90)
        {
            Console.WriteLine("Your Grade is an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your Grade is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your Grade is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your Grade is a D.");
        }
        else
        {
            Console.WriteLine("Your Grade is an F.");
        }
    }
}