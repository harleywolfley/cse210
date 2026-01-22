using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Janitor";
        job1._jubdescription = "Cleans";

        Job job2 = new Job();
        job2._jobTitle = "Developer";
        job2._jubdescription = "Coding";

        Resume myResume = new Resume();
        myResume._name = "Harley Wolfley";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();

    }

   
}
