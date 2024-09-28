using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> my_list;// = new List<int>();
        List<string> string_list = new();

        my_list = [24,25,36];
        string_list.Add("This was added");

        foreach (int Num in my_list)
        {
            Console.WriteLine(Num);
        }
        foreach (string Num in string_list)
        {
            Console.WriteLine(Num);
        }

        int user_input = 1;
        // This loop will gather data to fill up a list
        while(user_input != 0)
        {
            Console.Write("Enter Something: ");
            string the_string = Console.ReadLine();
            user_input = int.Parse(the_string);
            my_list.Add(user_input);
            Console.WriteLine(my_list[my_list.Count()-1]);
        }
        AwesomeFuction();

    }

    static void AwesomeFuction()
    {
        /*This will do something awesome!*/

        Console.WriteLine("sorry you weren't fast enough, you missed the awesome thing");

    }
}