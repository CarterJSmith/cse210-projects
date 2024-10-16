using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Bin myBin = new("Dollar", (float)0.25, 40);

        myBin.ModifyQuantity(+6);
        Console.WriteLine(myBin.CountValue());

        

    }
}