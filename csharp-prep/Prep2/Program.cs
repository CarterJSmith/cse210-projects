using System;

class Program
{
    static void Main(string[] args)
    {
        string letter_grade;
        int grade_percent;


        // Prompt user for grade percentage.
        Console.Write("Please enter your grade percentage: ");
        grade_percent = int.Parse(Console.ReadLine());

        // Determines letter grade.
        if( grade_percent >= 80)
        {
            if( grade_percent >=90)
            {
                letter_grade = "A";
            }
            else
            {
                letter_grade = "B";
            }
        }
        else
        {
            if ( grade_percent >= 70 )
            {
                letter_grade = "C";
            }
            else if ( grade_percent >=60 )
            {
                letter_grade = "D";
            }
            else
            {
                letter_grade = "F";
            }

        }

        // Did you pass. input greater than 70%.
        if (grade_percent >= 70)
        {
            Console.WriteLine("Congrats! You're Passing");
        }
        else
        {
            Console.WriteLine("Looks like we need to work on passing this class. Please contact the instructor.");
        }

        // Final print Final letter grade. 
        Console.WriteLine($"Your letter grade is: {letter_grade}");
    }
}