using System.Net.Sockets;

class Customer
{
    // attributes
    private string _customerName;
    private Address _customerAddress;
    private bool _usResident;

    // constructor
    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    // behaviors
    public bool IsUsResident()
    {
        _usResident = _customerAddress.IsUsResident();
        return _usResident;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.GetFullAddress();
    }


}