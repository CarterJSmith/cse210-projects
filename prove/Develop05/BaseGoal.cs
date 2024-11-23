using System.Text;
using System.IO; 

public class BaseGoal{
    
    protected int _totalPoints;
    protected bool _isComplete;
    protected int _points;
    protected string _goalName;
    protected string _description;
    private List<SimpleGoal> _simpleGoals = new List<SimpleGoal>();
    private List<EternalGoal> _eternalGoals = new List<EternalGoal>();
    private List<ChecklistGoals> _checklistGoals = new List<ChecklistGoals>();


    // Constructor
    public BaseGoal(){ 
        _totalPoints = 0;
        _simpleGoals = new List<SimpleGoal>();
        _eternalGoals = new List<EternalGoal>();
        _checklistGoals = new List<ChecklistGoals>();
    }

    // Behaviors

    public virtual void Record()
    {
        // for loop for each type of goal and prints only the name of the goal 
        for (int i = 1; i < _eternalGoals.Count+1; i++)
        {
            Console.WriteLine($"{i} {_eternalGoals[i-1]._goalName}");
        }

        for (int j = 0; j < _simpleGoals.Count; j++)
        {
            Console.WriteLine($"{j + _eternalGoals.Count + 1} {_simpleGoals[j]._goalName}");
        }

        for (int k = 0; k < _checklistGoals.Count; k++)
        {
            Console.WriteLine($"{k + _eternalGoals.Count + _simpleGoals.Count + 1} {_checklistGoals[k]._goalName}");
        }

        Console.WriteLine("Which goal did you complete or enter 0 to exit? ");
        int goalIndex = int.Parse(Console.ReadLine());


        bool goalUpdated = false;
        while (!goalUpdated)
        {
            try
            {
                // Goal offsets
                // this matchese the goal to the correct index
                int simpleGoalOffset = _eternalGoals.Count;
                int checklistGoalOffset = _eternalGoals.Count + _simpleGoals.Count;

                if (goalIndex > 0 && goalIndex <= _eternalGoals.Count)
                {
                    _eternalGoals[goalIndex - 1]._isComplete = true;
                    _totalPoints += _eternalGoals[goalIndex - 1]._points;
                    _eternalGoals[goalIndex-1]._isComplete = true;
                    goalUpdated = true;
                }
                else if (goalIndex > _eternalGoals.Count && goalIndex <= _eternalGoals.Count + _simpleGoals.Count)
                {
                    int simpleIndex = goalIndex - simpleGoalOffset - 1;
                    _totalPoints += _simpleGoals[simpleIndex]._points;
                    _simpleGoals[simpleIndex]._isComplete = true;
                    goalUpdated = true;
                }
                else if (goalIndex > _eternalGoals.Count + _simpleGoals.Count && goalIndex <= _eternalGoals.Count + _simpleGoals.Count + _checklistGoals.Count)
                {
                    int checklistIndex = goalIndex - checklistGoalOffset - 1;
                    _checklistGoals[checklistIndex].Record();
                    _totalPoints += _checklistGoals[checklistIndex]._points;
                    goalUpdated = true;
                }
                else if (goalIndex == 0)
                {
                    Console.WriteLine("Exiting without updating any goals.");
                    goalUpdated = true;
                }
                else
                {
                    Console.WriteLine("Invalid goal index. Please try again.");
                }

                Console.WriteLine("Goal updated!");
                Console.WriteLine($"\n\nTotal points: {_totalPoints}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid goal index. Please try again.");
            }
        }
               


    }

    public void LoadGoals()
    {
        string fileName;
        Console.WriteLine("What is the name of the file you would like to load from? ");
        fileName = Console.ReadLine();

        if (fileName == "")
        {
            fileName = "goals.txt";
        }

        string filePath = Path.GetFullPath(fileName);
        Console.WriteLine($"Attempting to load from file: {filePath}");

        try
        {
            using (StreamReader inputFile = new StreamReader(filePath))
            {
                // Read total points
                if (!int.TryParse(inputFile.ReadLine(), out _totalPoints))
                {
                    throw new InvalidDataException("The first line does not contain a valid total points value.");
                }

                // Clear existing goals
                _eternalGoals.Clear();
                _simpleGoals.Clear();
                _checklistGoals.Clear();

                // Read eternal goals until the first backtick
                string line;
                while ((line = inputFile.ReadLine()) != null && line != "`")
                {
                    string[] goalParts = line.Split('~');
                    if (goalParts.Length < 4)
                        throw new InvalidDataException($"Invalid goal format: {line}");

                    _eternalGoals.Add(new EternalGoal
                    {
                        _goalName = goalParts[0],
                        _description = goalParts[1],
                        _points = int.Parse(goalParts[2]),
                        _isComplete = bool.Parse(goalParts[3])
                    });
                }

                // Read simple goals until the next backtick
                while ((line = inputFile.ReadLine()) != null && line != "`")
                {
                    string[] goalParts = line.Split('~');
                    if (goalParts.Length < 4)
                        throw new InvalidDataException($"Invalid goal format: {line}");

                    _simpleGoals.Add(new SimpleGoal
                    {
                        _goalName = goalParts[0],
                        _description = goalParts[1],
                        _points = int.Parse(goalParts[2]),
                        _isComplete = bool.Parse(goalParts[3])
                    });
                }

                // Read checklist goals until the end of the file
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] goalParts = line.Split('~');
                    if (goalParts.Length < 4)
                        throw new InvalidDataException($"Invalid goal format: {line}");

                    _checklistGoals.Add(new ChecklistGoals
                    {
                        _goalName = goalParts[0],
                        _description = goalParts[1],
                        _points = int.Parse(goalParts[2]),
                        _isComplete = bool.Parse(goalParts[3])
                    });
                }

                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            Console.WriteLine($"Inner exception: {ex.InnerException}");
        }
    }



    public void SaveGoals()
    {
        string fileName;
        Console.WriteLine("What is the name of the file you would like to save to? ");
        fileName = Console.ReadLine();

        if (fileName == "")
        {
            fileName = "goals.txt";
        }

        string filePath = Path.GetFullPath(fileName);
        Console.WriteLine($"Attempting to save to file: {filePath}");

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                outputFile.WriteLine($"{_totalPoints}");
                if (_eternalGoals.Count > 0)
                {
                    foreach (var goal in _eternalGoals)
                    {
                        outputFile.WriteLine($"{goal._goalName}~{goal._description}~{goal._points}~{goal._isComplete}");
                    }
                }

                outputFile.WriteLine("`");

                if (_simpleGoals.Count > 0)
                {
                    foreach (var goal in _simpleGoals)
                    {
                        outputFile.WriteLine($"{goal._goalName}~{goal._description}~{goal._points}~{goal._isComplete}");
                    }
                }

                outputFile.WriteLine("`");

                if (_checklistGoals.Count > 0)
                {
                    foreach (var goal in _checklistGoals)
                    {
                        outputFile.WriteLine($"{goal._goalName}~{goal._description}~{goal._points}~{goal._isComplete}");
                    }
                }
            }

            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
            Console.WriteLine($"Inner exception: {ex.InnerException}");
        }
    }



    public virtual string Display(){
        // This function displays all the goals by creating a string containing many lines of text
        //   it also calls the display function of the child class of checklistGoals to print the 
        //   checklist goals in the correct format 

        // display eternal goals
        StringBuilder result = new StringBuilder();

        // Display eternal goals
        for (int i = 0; i < _eternalGoals.Count; i++)
        {
            if (_eternalGoals[i]._isComplete)
            {
                result.AppendLine($"{i + 1}. [X] {_eternalGoals[i]._goalName} ({_eternalGoals[i]._description})");
            }
            else result.AppendLine($"{i + 1}. [ ] {_eternalGoals[i]._goalName} ({_eternalGoals[i]._description})");
        }

        // Display simple goals
        for (int j = 0; j < _simpleGoals.Count; j++)
        {
            if (_simpleGoals[j]._isComplete)
            {
                result.AppendLine($"{j + _eternalGoals.Count + 1}. [X] {_simpleGoals[j]._goalName} ({_simpleGoals[j]._description})");
            }
            else result.AppendLine($"{j + _eternalGoals.Count + 1}. [ ] {_simpleGoals[j]._goalName} ({_simpleGoals[j]._description})");
        }

        // Display checklist goals
        for (int k = 0; k < _checklistGoals.Count; k++)
        {
            if (_checklistGoals[k]._isComplete)
            {
                result.AppendLine($"{k + _eternalGoals.Count + _simpleGoals.Count + 1}. [X] {_checklistGoals[k].Display()}");
            }
            else result.AppendLine($"{k + _eternalGoals.Count + _simpleGoals.Count + 1}. [ ] {_checklistGoals[k].Display()}");
        }
        
        result.AppendLine($"\n\nTotal points: {_totalPoints}");

        return result.ToString();
    }

    public virtual void CreateGoal()
    {


        int option;
        bool userSelection = false;
        while (!userSelection)
        {
            Console.WriteLine("The types of goals are: ");
            Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        
            try
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.CreateGoal();

                        _simpleGoals.Add(simpleGoal);

                        userSelection = true;
                        break;
                    case 2:
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.CreateGoal();

                        _eternalGoals.Add(eternalGoal);
                        userSelection = true;
                        break;
                    case 3:
                        ChecklistGoals checklistGoal = new ChecklistGoals();
                        checklistGoal.CreateGoal();

                        _checklistGoals.Add(checklistGoal);
                        userSelection = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again");
                        break;
            
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

    }


}