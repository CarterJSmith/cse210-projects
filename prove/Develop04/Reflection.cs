class Reflection : Activity
{
    private string _activityName = "Reflection";
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _reflectionPrompts = new List<string>{
        "What is a time in your life when you stood up for someone else?",
        "What is a time when you did something really difficult?",
        "What is a time when you helped someone in need?",
        "What is a time when you did something truly selfless?",
    };

    private List<string> _reflectionQuestions = new List<string>{ 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",        
        "What made this experience different than other experiences you have had?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "what did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    private int _randomPromptIndex;
    private int _randomQuestionIndex;

    public Reflection()
    {
        Random random = new Random();
        
        _randomPromptIndex = random.Next(1, _reflectionPrompts.Count);
        _randomQuestionIndex = random.Next(1, _reflectionQuestions.Count);
    }

    public void ReflectionActivity()
    {
        DateTime startTime = RunActivity(_activityName, _description);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("------ " + _reflectionPrompts[_randomPromptIndex-1] + " ------");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        // while in time loop
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {

            Console.Write(_reflectionQuestions[_randomQuestionIndex-1]);
            SimpleLoadingAnimation();
            if (_randomPromptIndex == _reflectionPrompts.Count - 1)
            {
                _randomQuestionIndex= 1;
            }
            else _randomQuestionIndex += 1;
        }

        EndMessage(_activityName);
    }




    
}