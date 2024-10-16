using System.Diagnostics.Contracts;
using System.Globalization;

class Bin
{
    // attributes
    private string _denomination;
    private float _value;
    private int _quantity;

    // behaviors 
    public Bin(string denom, float value, int quantity)
    {
        _denomination = denom;
        _value = value;
        _quantity = quantity;
    }

    public void ModifyQuantity(int exchange)
    {
        _quantity += exchange;
    }

    public float CountValue()
    {
        return _quantity * _value;
    }
}