class Prompt
{
    
    List<string> promptQuestions = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one thing I am grateful for today?",
        "What did I learn today?",
        "What challenge did I overcome today?",
        "Who did I serve or help today?",
        "What made me smile or laugh today?",
        "What is one thing I could improve on tomorrow?",
        "What is something that inspired me today?",
        "How did I show kindness today?",
        "What did I do to take care of myself today?"
    };


    // Behaviors. 

    // prompts 
    public string GeneratePrompt(){
        Random random = new();
        int randomNumber = random.Next(0, 13);

        return promptQuestions[randomNumber];

    }
}