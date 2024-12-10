class Event
{
    // Attributes
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Constructor
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // behaviors
    public void DisplayStandardDetails()
    {
        //Lists the title, description, date, time, and address.
        Console.WriteLine($"{_eventTitle}\n{_description}\n{_date}\n{_time}\n{_address.GetFullAddress()}");

    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("\n");
        DisplayStandardDetails();
        // prints the extra detail for each event
        if (this is Lecture)
        {
            // ((Lecture)this).GetSpeaker() casts the object to a lecture to access the .getMethod().
            Console.WriteLine($"Speaker: {((Lecture)this).GetSpeaker()}");
            Console.WriteLine($"Capacity: {((Lecture)this).GetMaxCapacity()}");
        }
        else if (this is Outdoor)
        {
            Console.WriteLine($"Weather: {((Outdoor)this).GetWeatherForcast()}");
        }
        else if (this is Reception)
        {
            Console.WriteLine($"Rsvp Contact: {((Reception)this).GetRsvpContact()}");
        }

    }

    public void DisplaySimpleDescription()
    {
        Console.WriteLine("\n");
        // this.GetType().Name returns the name of the class
        Console.WriteLine($"{this.GetType().Name} Event: - {_eventTitle} at {_date}");
        Console.WriteLine("\n");

    }

}