using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new();
        Console.WriteLine($"{newFraction.GetTop()}/{newFraction.GetBottom()}");

        Fraction newFraction1 = new(6);
        Console.WriteLine($"{newFraction1.GetTop()}/{newFraction1.GetBottom()}");

        Fraction newFraction2 = new(6,7);
        Console.WriteLine($"{newFraction2.GetTop()}/{newFraction2.GetBottom()}");

        // test data 
        Console.WriteLine();
        Console.WriteLine();

        // Case 1: 1/1
        Fraction fraction1 = new Fraction();
        fraction1.SetTop(1);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // Case 2: 5/1
        Fraction fraction2 = new Fraction();
        fraction2.SetTop(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Case 3: 3/4
        Fraction fraction3 = new Fraction();
        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Case 4: 1/3
        Fraction fraction4 = new Fraction();
        fraction4.SetTop(1);
        fraction4.SetBottom(3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());


    }
}