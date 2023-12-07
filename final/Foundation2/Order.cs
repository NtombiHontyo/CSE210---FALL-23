using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product>_products;
    private List<Customer>_customer;

    public Order()
    {
        _products = new List<Product>();
         _customer = new List<Customer>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void AddCustomer(Customer customer)
    {
        _customer.Add(customer);
    }


    public void DisplayPackingLabel()
    {
        
        Console.WriteLine();
        Console.WriteLine("Packing Label");
        Console.WriteLine();
        foreach (Product product in _products)
        {
            Console.WriteLine(product.DisplayProductInfo());
        }
        Console.WriteLine();
    
    }
    public double CalculateTotalPrice()
    {
        double toTalPrice = 0;
        foreach (Product product in _products)
        {
            toTalPrice += product.GetTotalPriceOfProduct();
        }
        return toTalPrice + 35;
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine();
        foreach (Customer customer in _customer)
        {
            Console.WriteLine(customer.Display());
        }

    }
    

}