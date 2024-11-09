using System;

// Things I feel that exceed the the project 
// I added a try catch block to handle exceptions in the menu options to handle invalid inputs
// in the reflection activity, I added logic to loop through all the questions in the questions list
    // printing each question once before repeating a question 
// The listing activity only counts if the user inputs something
// I also used a list of frames for a loading animation as well as a spinner 


class Program
{
    static void Main(string[] args)
    {
        int option;
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity\n2. Reflection Activity\n3. Listing Activity\n4. Quit");
            
            try
            {
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Breathing breathing = new Breathing();
                        breathing.BreathingActivity();
                        break;
                    case 2:
                        Reflection reflection = new Reflection();
                        reflection.ReflectionActivity();
                        break;
                    case 3:
                        Listing listing = new Listing();
                        listing.ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye...");
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