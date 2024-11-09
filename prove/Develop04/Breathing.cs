class Breathing : Activity
{

    private string _activityName = "Breathing Activity";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly.";


    public Breathing()
    {
        
    }

    public void BreathingActivity()
    {
        DateTime startTime = RunActivity(_activityName, _description);

        // while in time loop
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("Breath in... ");
            for (int i = 5; i >= 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.WriteLine("");
            Console.Write("Breath out... ");
            for (int i = 5; i >= 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.WriteLine("");
        }

        EndMessage(_activityName);
    }



}