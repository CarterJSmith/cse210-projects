using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a random number
        Random randomGenerator = new Random();
        int random_number = randomGenerator.Next(1,101);
        int guessCounter = 0;
        int userGuess;
        bool correctGuess = false;

        while (!correctGuess)
        {
            Console.Write("What is your guess? ");
            //string guess = ;
            userGuess = int.Parse(Console.ReadLine());
            guessCounter += 1;

            if (userGuess == random_number)
            {
                correctGuess = true;
            }
            else if(userGuess > random_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine($"You guessed it! It took you {guessCounter} guesses!");
        
    }
}