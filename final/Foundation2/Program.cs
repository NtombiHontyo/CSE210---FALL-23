using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Orange", "OR001", 10, 2);
        Product product1 = new Product("Apple", "AP332", 10, 2);
        Product product2 = new Product("Bananas", "BAN401", 10, 2);

        Address addresss = new Address("5 Buller Street", "Durban", "KZN", "USA");
        Customer customerr = new Customer("Masande Stengile", addresss);
        
        Order order = new Order(customerr);
        order.AddProduct(product);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.DisplayPackingLabel();
        Console.WriteLine($"Total Price: {order.CalculateTotalPrice()}");  
        order.DisplayShippingLabel(); 

        Product product3 = new Product("Potatoes", "POT582", 10, 2);
        Product product4 = new Product("Onions", "ON878", 10, 2);
        Product product5 = new Product("Carrots", "CAR550", 10, 2);

        Address address = new Address("9 Venice Road", "East London", "Eastern Cape", "South Africa");
        Customer customer = new Customer("Ntombi Hontyo", address);

        Order order1 = new Order(customer);
        order1.AddProduct(product3);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order1.DisplayPackingLabel();
        Console.WriteLine($"Total Price {order1.CalculateTotalPrice()}");
        Console.WriteLine();
        order1.DisplayShippingLabel();



    }
}