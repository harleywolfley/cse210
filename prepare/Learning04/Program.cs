using System;

class Program
{
    static void Main(string[] args)
    {
        Assign assign = new Assign();
        assign.GetSummary();
        if (_topic == "Math")
        {
            Math math = new Math();
            math.GetHWList();
        } else if (_topic == "English")
        {
            English english = new English();
            english.GetWrite();
        } else
        {
            Console.WriteLine("Invalid.");
        }
    }
}