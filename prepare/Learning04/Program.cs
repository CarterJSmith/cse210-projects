using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Allison Rose", "C#", "Section 6.3", "Problem 1.");
        WritingAssignment writingAssignment = new WritingAssignment("Jacob Tiller", "European History", "this is the title");

        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("");
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}