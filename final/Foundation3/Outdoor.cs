class Outdoor : Event
{
    public string _weatherForcast; 

    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weatherForcast) : base(eventTitle, description, date, time, address)
    {
        _weatherForcast = weatherForcast;
    }

    public string GetWeatherForcast()
    {
        return _weatherForcast;
    }
}