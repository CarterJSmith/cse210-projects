using System.Globalization;

class Costume
{
    // Attributes 
    // These are sometimes called member variables
    public string _headWear;
    public string _gloves;
    public string _shoes;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accessory;



    // Behaviors
    public void ShowWardrobe()
    {
        string result = $"";
        result += $"Head: {_headWear}\n";
        result += $"Gloves: {_gloves}\n";
        result += $"Shoes: {_shoes}\n";
        result += $"Torso: {_upperGarment}\n";
        result += $"Pants: {_lowerGarment}\n";
        result += $"Accessort: {_accessory}\n";
        Console.WriteLine(result);
    }
}