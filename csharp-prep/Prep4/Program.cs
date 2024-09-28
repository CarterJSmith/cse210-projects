using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> my_list = new();

        int user_input = 1;
        double average = 0;
        double sum = 0;
        int largest_num = 0;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop that adds the user input into a list. Quit when user enters 0
        // This loop will gather data to fill up a list
        while(user_input != 0)
        {
            Console.Write("Enter Number: ");
            user_input = int.Parse(Console.ReadLine());
            my_list.Add(user_input);

            // Keeps the sum.
            sum += user_input;

            // Finds the largest number.
            if (user_input > largest_num)
            {
                largest_num = user_input;
            }

        }

        // You need -1 to negate the 0 input 
        int numbersInputed = my_list.Count()-1;
        average = sum / numbersInputed;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {largest_num}");
    }
}