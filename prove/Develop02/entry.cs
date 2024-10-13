class Entry{


    // Attributes
    public string _journalInput; 
    public string _prompt;
    public DateTime _date;

    // Behaviors
    public void Display()
    {
        Console.WriteLine($"{_date.ToShortDateString()} - Prompt {_prompt}");
        Console.WriteLine(_journalInput);
    }

}