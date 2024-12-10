using System;
class Running : Activity
{
    // attributes
    private double _distance;

    // constructor
    public Running(string date, int timeInMinutes, double distance) : base(date, timeInMinutes)
    {
        _distance = distance;
    }

    // behaviors
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _timeInMinutes * 60 ;
    }

    public override double GetPace()
    {
        return _timeInMinutes / _distance;
    }
}