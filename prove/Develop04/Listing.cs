class Listing : Activity
{
    private string _activityName = "Listing";
    private string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
    private int _randomPromptIndex;
    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "People that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public Listing()
    {
        Random random = new Random();
        _randomPromptIndex = random.Next(1, _prompts.Count);
    }

    public void ListingActivity()
    {
        int listCounter = 0;
        DateTime startTime = RunActivity(_activityName, _activityDescription);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[_randomPromptIndex-1]} ---");

        // displays countdown
        Console.Write("Get ready... ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b4");
        Thread.Sleep(1000);
        Console.Write("\b3");
        Thread.Sleep(1000);
        Console.Write("\b2");
        Thread.Sleep(1000);
        Console.Write("\b1"); 
        Console.Write("\b ");
        Console.WriteLine();

        // while in time loop
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            // The counter is only incremented if the user inputs something
            if (Console.ReadLine().Length >= 1)
            {
                listCounter++;
            }
        }

        Console.WriteLine("\nYou listed " + listCounter + " items.");

        EndMessage(_activityName);
    }
}