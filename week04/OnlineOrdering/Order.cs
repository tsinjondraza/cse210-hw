public class Order
{
    private Customer _customer;
    private List<Product> _items;

    public Order(Customer customer, List<Product> orders)
    {
        _customer = customer;
        _items = orders;
    }
    public double GetTotalCost()
    {
        double shippingCost = 0;
        double itemCost = 0;
        if (_customer.LivesInTheUS())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        foreach (Product item in _items)
        {
            itemCost += item.GetTotalCost();
        }
        return itemCost + shippingCost;

    }

    public string DisplayShippingLabel()
    {
        return _customer.GetCustomerResidence();
    }

    public string DisplayPackingLabel()
    {
        string label = "";
        foreach (Product item in _items)
        {
            label += (item.DisplayProductLabel() + Environment.NewLine);
        }
        return label;
    }
}