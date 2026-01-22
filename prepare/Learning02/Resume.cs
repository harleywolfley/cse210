public class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job work in _jobList)
        {
            work.Display();
        }
    }
}