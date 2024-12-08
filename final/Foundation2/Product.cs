class Product
{
    // attributes
    private string _productName;
    private int _productUID;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string productName, int productUID, double price, int quantity)
    {
        _productName = productName;
        _productUID = productUID;
        _price = price;
        _quantity = quantity;
    }

    // behaviors
    public double GetTotalPrice()
    {
        // returns the total price of the product
        return _price * _quantity;
    }

    //Gets and returns the the private variables for each product
    public List<String> GetProductInfo()
    {
        // create a list of strings containing the product info
        List<String> productInfo =
        [
            _productName,
            _productUID.ToString(),
            _quantity.ToString(),
        ];

        return productInfo;
    }

}