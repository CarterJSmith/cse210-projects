using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates each event. 
        Lecture lecture = new Lecture("C# Basics", "Learn the basics of C# programming", "2023-09-01", "10:00 AM", new Address("123 Main St", "Anytown", "CA", "12345"), "Bro Smith", 50);
        Reception reception = new Reception("Welcome Party", "Join us for a welcoming ceremony", "2023-09-01", "4:00 PM", new Address("456 Elm St", "Des Moines", "IA", "50169"), "Agoodemail@example.com");
        Outdoor outdoor = new Outdoor("Picnic", "Join us for a picnic", "2023-09-01", "12:00 PM", new Address("789 Oak St", "San Francisco", "CA", "58966"), "Sunny with a 5% chance of rain");

        lecture.DisplayStandardDetails();
        lecture.DisplayFullDetails();
        lecture.DisplaySimpleDescription();

        Console.WriteLine("----------------------------------");

        reception.DisplayStandardDetails();
        reception.DisplayFullDetails();
        reception.DisplaySimpleDescription();

        Console.WriteLine("----------------------------------");


        outdoor.DisplayStandardDetails();
        outdoor.DisplayFullDetails();
        outdoor.DisplaySimpleDescription();
    }
}