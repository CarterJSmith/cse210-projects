using System;
class Cycling : Activity 
{
    // attributes
    private double _speed;

    // constructor
    public Cycling(string date, int timeInMinutes, double speed) : base(date, timeInMinutes)
    {
        _speed = speed;
    }

    // behaviors
    public override double GetDistance()
    {
        return _speed * _timeInMinutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return _timeInMinutes / GetDistance();
    }
}