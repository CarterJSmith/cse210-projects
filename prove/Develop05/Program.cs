using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the Eternal quest program 
        int option;
        BaseGoal baseGoal = new BaseGoal();
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            
            try
            {
                
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        // Create a new goal
                        baseGoal.CreateGoal();
                        break;
                    case 2:
                        // Display the goals currently loaded 
                        Console.WriteLine(baseGoal.Display());
                        break;
                    case 3:
                        // Save the goals to a file 
                        baseGoal.SaveGoals();
                        break;
                    case 4:
                        // Load the goals from a file 
                        baseGoal.LoadGoals();
                        break;
                    case 5:
                        // Record an event
                        baseGoal.Record();
                        break;
                    case 6:
                        // Quit the program 
                        return;
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