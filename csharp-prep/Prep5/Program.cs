using System;

class Program
{
    static void Main(string[] args)
    {
        // Displays the welcome message 
        static void DisplayWelcome()
        {
            Console.Write("Welcome to the program!");
        }

        // Prompts the user for their name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        // asks for the users favorite number 
        static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            int favNum = int.Parse(Console.ReadLine());
            
            return favNum;
        }

        // takes given number and squares the number 
        static int SquareNumber(int userNum)
        {
            int numSqrd = userNum * userNum;

            return numSqrd;
        }

        // displays the final message 
        static void Display(string userName, int numSqrd)
        {
            Console.WriteLine($"{userName}, the square of your number is {numSqrd}");
        }

        // Runs the program 
        static void Run()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int favNum = PromptUserNumber();
            int numSqrd = SquareNumber(favNum);
            Display(userName, numSqrd); 
        }

        Run();
    }
}