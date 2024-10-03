class Resume
{
    // Attributes.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Behaviors.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        // This will run through the all the jobs in the jobs list.
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}