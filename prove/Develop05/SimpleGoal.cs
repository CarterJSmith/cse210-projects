class SimpleGoal : BaseGoal
{
    // attribute

    public SimpleGoal(){
        _goalName = "SimpleGoal";
        _description = "SimpleGoal";
        _points = 0;
        
    }
    // behaviors
    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points would you like to assign to this goal? ");
        _points = int.Parse(Console.ReadLine());
        // _totalPoints = _points;

    }
}