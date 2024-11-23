public class ChecklistGoals : BaseGoal
{
    protected int _numTimesCompleted;
    private int _numTimesToComplete;
    private int _bonusPoints;

    public ChecklistGoals()
    {
        _goalName = "ChecklistGoal";
        _description = "ChecklistGoal";
        _points = 0; 
        _numTimesCompleted = 0;
        _numTimesToComplete = 0;
        _bonusPoints = 0;

    }

    public override void Record()
    {
        _numTimesCompleted += 1;
        if (_numTimesCompleted == _numTimesToComplete)
        {
            _points = _bonusPoints;
            _isComplete = true;
        }
    }

    public override string Display()
    {
        return $"{_goalName} ({_description}) -- Currently Completed:{_numTimesCompleted}/{_numTimesToComplete}";
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points would you like to assign to this goal? ");
        _points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be completed? ");
        _numTimesToComplete = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus points for completing this goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
}