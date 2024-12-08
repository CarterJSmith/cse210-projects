class Order
{
    // attributes
    private List<Product> _products = new List<Product>();
    private Customer _customerName;
    private double _totalCost;

    // constructor
    public Order(List<Product> products, Customer customerName)
    {
        _products = products;
        _customerName = customerName;
    }

    // behaviors

    // displays packing label
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        // the "-" is used to {value,-width} to create consistent column widths (AI assisted with "Width value")
        Console.WriteLine($"{"Item",-20}{"ID",-15}{"Quantity",-10}");
        Console.WriteLine(new string('-', 45)); 

        foreach (Product product in _products)
        {
            List<string> productInfo = product.GetProductInfo();
            // productInfo[0] = productName, productInfo[1] = productUID, productInfo[2] = quantity
            Console.WriteLine($"{productInfo[0],-20}{productInfo[1],-15}{productInfo[2],-10}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine($"{_customerName.GetCustomerName()}");
        Console.WriteLine($"{_customerName.GetCustomerAddress()}");
    }

    
    public double ComputeCost()
    {
        // compute total cost of all products in the order
        _totalCost = 0;
        foreach (Product product in _products)
        {
            _totalCost += product.GetTotalPrice();
        }

        // If the customer is not from the US, add $35 to the total cost else add $5 for shipping
        if (!_customerName.IsUsResident())
        {
            _totalCost += 35;
        }
        else 
        {
            _totalCost += 5;
        }

        return _totalCost;
    }

    public void DisplayLabel()
    {
        // display packing and shipping labels with the total cost of shipping
        DisplayPackingLabel();
        DisplayShippingLabel();

        Console.WriteLine($"\nTotal Cost: \n{ComputeCost()}");
    }
}