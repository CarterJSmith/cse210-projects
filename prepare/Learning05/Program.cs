using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4.0);
        Console.WriteLine($"The area of the square is {square.GetArea()}");
        Rectangle rectangle = new Rectangle("Blue", 5.0, 3.0);
        Console.WriteLine($"The area of the rectangle is {rectangle.GetArea()}");
        Circle circle = new Circle(6.0, "Green");
        Console.WriteLine($"The area of the circle is {circle.GetArea()}");
    }
}