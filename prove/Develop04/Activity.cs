using System.Globalization;

class Activity
{
    protected int _duration;

    // Constructor
    public Activity()
    {
       
    }

    public void StartMessage(string activityName, string description)
    {
        Console.WriteLine($"Welcome to the {activityName}.\n");
        Console.WriteLine(description);

    }

    public void EndMessage(string activityName)
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {activityName} Activity.\n");
    }

    public void LoadingAnimation()
    {
        // Responseble for displaying the loading animation
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(1500);

        // Define the animation frames
        string[] frames = {
            @"
                 _____
                | o   |
                |     |
                |_____|
            ",
            @"
                 _____
                |     |
                |     |
                |_____|
            ",
            @"
                 _____
                |  o  |
                |     |
                |_____|
            ",
            @"
                 _____
                |     |
                |     |
                |_____|
            ",
            @"
                 _____
                |   o |
                |     |
                |_____|
            ",
            @"
                 _____
                |     |
                |     |
                |_____|
            ",
            @"
                 _____
                |     |
                | o   |
                |_____|
            "
            ,@"
                 _____
                |     |
                |     |
                |_____|
            ",
            @"
                 _____
                |     |
                |  o  |
                |_____|
            ",
            @"
                 _____
                |     |
                |     |
                |_____|
            ",@"
                 _____
                |     |
                |   o |
                |_____|
            ",
            @"
                 _____
                |     |
                |     |
                |_____|
            "
        };

        // Run the animation for 4 seconds
        int duration = 4000;
        int frameDelay = 100; // 0.1 seconds per frame
        int frameCount = duration / frameDelay;

        for (int i = 0; i < frameCount; i++)
        {
            // Clear the console and print the current frame
            Console.Clear();
            Console.WriteLine(frames[i % frames.Length]);
            Thread.Sleep(frameDelay);
        }

    }


    public void SimpleLoadingAnimation()
    {
        for (int i = 3; i >= 0; i--)
        {
            Console.Write("|");
            Thread.Sleep(500);

            // Overwrite the character with `/`
            Console.Write("\b/");
            Thread.Sleep(500);

            // Overwrite with backslash `\`
            Console.Write("\b\\");
            Thread.Sleep(500);

            // Clear the character and move back again to reset 
            Console.Write("\b ");
            Console.Write("\b"); 
        }

        // Move to a new line after finishing
        Console.WriteLine();
        
    }

    public void GetDuration()
    {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());

    }

    public DateTime RunActivity(string activityName, string description)
    {
        StartMessage(activityName, description);
        GetDuration();
        LoadingAnimation();

        DateTime startTime = DateTime.Now;

        return startTime;   
    }
}