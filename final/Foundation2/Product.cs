public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product()
    {
        _productName = "";
        _productId = "";
        _price = 0;
        _quantity = 0;
    }
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    

    public double GetTotalPriceOfProduct()
    {
        return _price * _quantity;
    }

    public string DisplayProductInfo()
    {
        return $"{_productName}: {_productId}";
    }
}