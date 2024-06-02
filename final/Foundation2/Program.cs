using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address nonUsaAddress = new Address("456 Elm St", "Othertown", "ON", "Canada");

        // Create customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        // Create products
        Product product1 = new Product("Laptop", "1001", 1200, 1);
        Product product2 = new Product("Mouse", "1002", 30, 2);
        Product product3 = new Product("Keyboard", "1003", 50, 1);

        // Create orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}


class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string StateProvince { get; set; }
    private string Country { get; set; }

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressDetails()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}

class Customer
{
    private string Name { get; set; }
    private Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetName()
    {
        return Name;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Name}\n{Address.GetAddressDetails()}";
    }
}

class Product
{
    private string Name { get; set; }
    private string ProductId { get; set; }
    private double Price { get; set; }
    private int Quantity { get; set; }

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }

    public string GetPackingLabel()
    {
        return $"Name: {Name}, Product ID: {ProductId}";
    }
}

class Order
{
    private List<Product> Products { get; set; }
    private Customer Customer { get; set; }

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += Customer.IsInUSA() ? 5 : 35; // Shipping cost
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in Products)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return Customer.GetShippingLabel();
    }
}