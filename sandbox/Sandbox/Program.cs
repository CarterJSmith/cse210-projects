using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // nurse is an instance of a class, and an instance is an object 
        Costume nurse = new();
        nurse._headWear = "Facemask";
        nurse._gloves = "Nitrile";
        nurse._shoes = "sneakers";
        nurse._upperGarment = "scrubs";
        nurse._lowerGarment = "scrubs";
        nurse._accessory = "Stethoscope";

        

        Costume detective = new Costume();
        detective._headWear = "Fedora";
        detective._gloves = "Leather";
        detective._shoes = "Loafers";
        detective._upperGarment = "Trench coat";
        detective._lowerGarment = "Slacks";
        detective._accessory = "Notepad";
        

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        

    }
}