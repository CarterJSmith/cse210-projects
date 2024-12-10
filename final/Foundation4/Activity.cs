class Activity
{
    // attributes
    protected string _date;
    protected int _timeInMinutes;

    // constructor
    public Activity(string date, int timeInMinutes)
    {
        _date = date;
        _timeInMinutes = timeInMinutes;
    }

    // behaviors
    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual void GetSummary()
    {
        // example output 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date} {GetType().Name} ({_timeInMinutes} min): Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km");
    }

}