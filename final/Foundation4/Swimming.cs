using System;

class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int timeInMinutes, int numLaps) : base(date, timeInMinutes)
    {
        _numLaps = numLaps;
    }    

    public override double GetDistance()
    {
        return _numLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _timeInMinutes * 60;
    }

    public override double GetPace()
    {
        return _timeInMinutes / GetDistance();
    }


}