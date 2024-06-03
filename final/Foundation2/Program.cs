using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address _firstAddress = new Address("4 Main road", "Melville", "Johannesburg", "R.S.A");
        Address _secondAddress = new Address("6 Owode estate, Apata", "Ibadan", "Oyo", "Nigeria");

        // Create customers
        Customer _firstCustomer = new Customer("Oreoluwa Adelabu", _firstAddress);
        Customer _secondCustomer = new Customer("Blessing Okon", _secondAddress);

        // Create products
        Product product1 = new Product("Bag", "1001", 1900, 1);
        Product product2 = new Product("Sandal", "1002", 20, 2);
        Product product3 = new Product("Gown", "1003", 15, 1);

        // Create orders
        Order order1 = new Order(_firstCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(_secondCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: R" + order1.GetTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: N" + order2.GetTotalCost());
    }
}


class Address
{
    private string Street { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool Country1()
    {
        return Country.Equals("Republic of South Africa", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressDetails()
    {
        return $"{Street}, {City}, {State}, {Country}";
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

    public bool Country1()
    {
        return Address.Country1();
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
        totalCost += Customer.Country1() ? 5 : 35; // Shipping cost
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