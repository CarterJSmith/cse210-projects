class Lecture : Event
{
    // Attributes
    private string _speaker;
    private int _maxCapacity;

    // Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCapacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    // behaviors
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetMaxCapacity()
    {
        return _maxCapacity;
    }
}