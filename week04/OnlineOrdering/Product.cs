public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;
    public Product(string name, string id, double price, double quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
    public string DisplayProductLabel()
    {
        return $"{_name}, ID: {_productId}";
    }
}