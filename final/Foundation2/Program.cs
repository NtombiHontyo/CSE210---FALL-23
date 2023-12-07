using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Orange", "OR001", 53.99, 5);
        Product product1 = new Product("Apple", "AP332", 15.20, 2);
        Product product2 = new Product("Bananas", "BAN401", 18.00, 3);
        
        Order order = new Order();
        order.AddProduct(product);
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.DisplayPackingLabel();
        Console.WriteLine($"Total Price: {order.CalculateTotalPrice()}");  

         Address addresss = new Address("5 Buller Street", "Durban", "KZN", "USA");
        Customer customerr = new Customer("Masande Stengile", addresss);
        order.AddCustomer(customerr);
        order.DisplayShippingLabel(); 

        Product product3 = new Product("Potatoes", "POT582", 60.11, 15);
        Product product4 = new Product("Onions", "ON878", 41.99, 7);
        Product product5 = new Product("Carrots", "CAR550", 28.00, 3);

        Order order1 = new Order();
        order1.AddProduct(product3);
        order1.AddProduct(product4);
        order1.AddProduct(product5);
        order1.DisplayPackingLabel();
        Console.WriteLine($"Total Price {order1.CalculateTotalPrice()}");
        Console.WriteLine();

        Address address = new Address("9 Venice Road", "East London", "Eastern Cape", "South Africa");
        Customer customer = new Customer("Ntombi Hontyo", address);
        order1.AddCustomer(customer);
        order1.DisplayShippingLabel();



    }
}