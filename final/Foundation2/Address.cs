class Address
{
    // attributes
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    // behaviors
    public bool IsUsResident()
    {
        // This will return true if the country is "United States" any other value will return false
        return _country == "United States";
    }

    // Prints the full address
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
    }
}