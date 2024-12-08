using System;

class Program
{
    static void Main(string[] args)
    {
         // First Order, US Customer
        Product product1 = new Product("Apples", 1001, 1.99, 10);
        Product product2 = new Product("Bread", 1002, 2.99, 2);
        Product product3 = new Product("Milk", 1003, 3.49, 1);

        // Create a list of products
        List<Product> productsOrder1 = new List<Product>
        {
            product1, product2, product3
        };

        // Create a customer and address for the order
        Address address1 = new Address("456 Elm St.", "Springfield", "IL", "United States");
        Customer customer1 = new Customer("Alice Smith", address1);

        Order order1 = new Order(productsOrder1, customer1);

        // Second Order, International Customer
        Product product4 = new Product("Pasta", 2001, 5.99, 3);
        Product product5 = new Product("Olive Oil", 2002, 15.49, 1);
        Product product6 = new Product("Parmesan Cheese", 2003, 8.99, 2);

        // Create a list of products
        List<Product> productsOrder2 = new List<Product>
        {
            product4, product5, product6
        };

        // Create a customer and address for the order
        Address address2 = new Address("789 Piazza St.", "Rome", "RM", "Italy");
        Customer customer2 = new Customer("Marco Rossi", address2);

        Order order2 = new Order(productsOrder2, customer2);

        // Display the packing labels for both orders
        order1.DisplayLabel();

        order2.DisplayLabel();
    }
}