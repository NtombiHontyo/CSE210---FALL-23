using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product>_products;
    private Customer _customer;
    private double _shippingprice;

    public Order(Customer customer)
    {
        _products = new List<Product>();
         _customer = customer;
         _shippingprice = 35;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
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
        if (_customer.IsinUSA())
        {
            _shippingprice = 5;
        }
        return toTalPrice + _shippingprice;
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine();
        
        Console.WriteLine(_customer.Display());
        

    }
    

}